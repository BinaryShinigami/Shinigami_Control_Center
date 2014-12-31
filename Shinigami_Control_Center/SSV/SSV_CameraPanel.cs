using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Shinigami_Security_Viewer.SSV
{
    class SSV_CameraPanel : PictureBox
    {

        public Bitmap m_Contents;
        private SSV_Camera m_ParentClass;
        public SSV_CameraPanel(SSV_Camera parent) 
        {
            m_ParentClass = parent;
        }

        public void setImage(Bitmap image)
        {
            this.m_Contents = image;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs eventArgs)
        {
            base.OnPaint(eventArgs);

            if (this.m_Contents != null)
            {
                eventArgs.Graphics.DrawImage(this.m_Contents, new Point(0, 0));
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
    }
}
