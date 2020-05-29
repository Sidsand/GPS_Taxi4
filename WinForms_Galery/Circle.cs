using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Galery
{
    class Circle : Galery
    {
        private Bitmap bitmap = new Bitmap(Properties.Resources.Kar1);

        public Circle() : base() { }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
            Region = new Region(graphicsPath);
        }
    }
}
