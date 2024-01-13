using System.Data;
using TreePrunServices.Core.Gis.Contracts.Projections;
using TreePrunServices.Core.Gis.Entities;

namespace TreePrunServices.Infra.Data.DataBase.DataBaseSQLite.Projections
{
    public class WireProjection : IWireProjection<IDataReader>
    {
        public Wire Get(IDataReader from)
        {
            throw new NotImplementedException();
        }
    }
}
