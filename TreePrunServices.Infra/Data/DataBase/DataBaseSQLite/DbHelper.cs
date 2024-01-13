
using System.Data.SQLite;

namespace TreePrunServices.Infra.Data.DataBase.DataBaseSQLite
{
    public class DbHelper
    {
        public static void CreateDataBaseSQLite(string name)
        {
            try
            {
                SQLiteConnection.CreateFile($"{name}.sqlite");
            }
            catch
            {
                throw;
            }
        }
    }
}
