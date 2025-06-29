using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveGraphicalApp.Infraestructure.Graphics
{
    public interface IImageExporter
    {
        void exportImage(object sender, EventArgs e);
    }
}
