using System.Data;
using TreePrunServices.Core.Gis.Contracts.Projections;
using TreePrunServices.Core.Gis.Entities;

namespace TreePrunServices.Infra.Data.DataBase.DataBaseSQLite.Projections
{
    public class PoleProjection : IPoleProjection<IDataReader>
    {
        public Pole Get(IDataReader from)
        {
            throw new NotImplementedException();
        }
    }
}
