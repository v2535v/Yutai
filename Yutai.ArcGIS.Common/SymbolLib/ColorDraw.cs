using System.Drawing;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;

namespace Yutai.ArcGIS.Common.SymbolLib
{
    public class ColorDraw : StyleDraw
    {
        public ColorDraw(IColor icolor_0) : base(icolor_0)
        {
        }

        public override void Draw(int int_0, Rectangle rectangle_0, double double_0, double double_1)
        {
            IStyleGalleryClass styleGalleryClass = new ColorStyleGalleryClass();
            tagRECT tagRECT = default(tagRECT);
            tagRECT.left = rectangle_0.Left;
            tagRECT.right = rectangle_0.Right;
            tagRECT.top = rectangle_0.Top;
            tagRECT.bottom = rectangle_0.Bottom;
            styleGalleryClass.Preview(this.m_pStyle, int_0, ref tagRECT);
        }
    }
}