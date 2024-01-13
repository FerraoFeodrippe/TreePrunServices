using System.Data;
using System.Data.SQLite;
using TreePrunServices.Core.Gis.Contracts.Projections;
using TreePrunServices.Cross.Definitions.DataFlow;
using TreePrunServices.Cross.Settings;

namespace TreePrunServices.Infra.Data.DataBase.DataBaseSQLite
{
    public abstract class BaseRepository
    {
        private static object __locker = new ();

        protected BaseRepository() { }

        private static SQLiteConnection DbConnection()
        {
            var infoSqlite = SettingsManager.Get("DataBaseMock:SQLite");
            var path = Path.Combine(Directory.GetCurrentDirectory(), "MockData", infoSqlite?.GetSection("DataBaseName").Value ?? string.Empty);
            SQLiteConnection sqliteConnection = new ($"Data Source={path}; Version={infoSqlite?.GetSection("Version").Value};");
            lock (__locker)
            {
                sqliteConnection.Open();
            }
            return sqliteConnection;
        }

        public static DataResponse<bool> Execute(string cmdStr)
        {
            DataResponse<bool> response;

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = cmdStr;
                    cmd.ExecuteNonQuery();
                    response= DataResponse<bool>.Create(true);
                }
            }
            catch (Exception ex)
            {
                response = DataResponse<bool>.Create(false);

                if (ex != null)
                {
                    response.AddError(ex.TargetSite?.Name ?? nameof(Query), ex);
                }
                else
                {
                    response.AddError(nameof(Execute), $"A error ocurred but without exception Error in TreePrunServices.Infra.Data.DataBase.DataBaseSQLite.BaseRepository.{nameof(Execute)}");
                }
            }

            return response;
        }

        private static IEnumerable<T> GetProjections<T>(IDataReader dataReader , IProjection<IDataReader, T> projection)
        {
            while (dataReader.Read())
            {
                yield return projection.Get(dataReader);
            }
        }

        public static DataResponse<T[]>? Query<T>(DataRequest request, string query, IProjection<IDataReader, T> projection) where T : new()
        {
            DataResponse<T[]> response;
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = query;
                    using (var reader = cmd.ExecuteReader())
                    {
                        response = DataResponse<T[]>.Create(GetProjections(reader, projection).ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                response = DataResponse<T[]>.Create();

                if (ex != null)
                {
                    response.AddError(ex.TargetSite?.Name ?? nameof(Query), ex);
                }
                else
                {
                    response.AddError(nameof(Query), $"A error ocurred but without exception Error in TreePrunServices.Infra.Data.DataBase.DataBaseSQLite.BaseRepository.{nameof(Query)}");
                }
            }

            return response;
        }
    }
}
