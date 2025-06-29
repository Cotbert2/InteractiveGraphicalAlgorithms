using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveGraphicalApp.Core.Ports
{
    public interface ILineRasterizer
    {
        List<Point> DrawLine(int x0, int y0, int x1, int y1);

    }
}
