using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.SystemUI;

namespace Yutai.ArcGIS.Common.Carto
{
    public interface IDeleteElementOperation : IOperation
    {
        IActiveView ActiveView { set; }

        IEnumElement Elements { set; }

        IPoint Point { set; }
    }
}