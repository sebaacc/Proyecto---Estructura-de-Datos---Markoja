using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdMarkoja
{
    public class clsLightPastelMenuStripRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(144, 202, 249)), e.Item.ContentRectangle); // Azul pastel más oscuro
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
    }
}
