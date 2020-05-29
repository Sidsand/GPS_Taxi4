using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Galery
{
    class Galery : HoverButton
    {
        private Bitmap bitmap = new Bitmap(Properties.Resources.Kar1); 
        
        private int i = 1;

        private string text = "";

        public Galery() : base()
        {
            
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            if (i == 1)
                text = "Это первое изображение ";
            if (i == 2)
                text = "Это кажется второе";
            if (i == 3)
                text = "А это последнее";
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            text = "";
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            if(i==1)
                bitmap = new Bitmap(Properties.Resources.Kar1);
            if (i == 2)
                bitmap = new Bitmap(Properties.Resources.Kar2);
            if (i == 3)
                bitmap = new Bitmap(Properties.Resources.Kar3);
                   
            

            pevent.Graphics.DrawImage(bitmap, 0, 0);
            
            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            
            pevent.Graphics.DrawString(text, Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            i++;
            
            if (i > 3)
                i = 1;
        }
    }
}
