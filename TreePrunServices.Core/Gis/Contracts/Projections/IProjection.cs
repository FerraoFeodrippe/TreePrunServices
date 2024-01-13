namespace TreePrunServices.Core.Gis.Contracts.Projections
{
    public interface IProjection<In, Out>
    {
        Out Get(In from);
    }
}
