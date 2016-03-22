using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shinigami_Control_Center
{
    public partial class CameraView : Form
    {
        public Shinigami_Security_Viewer.SSV.SSV_Camera m_Camera;
        public int m_CameraId = 0;

        public CameraView(Shinigami_Security_Viewer.SSV.SSV_Camera cam)
        {
            InitializeComponent();

            this.m_Camera = cam;
            this.m_CameraId = cam.m_CameraId;
            addCameraPanel(cam.getCameraPanel());
            setTitle(cam.m_CameraName);

        }

        private void addCameraPanel(Shinigami_Security_Viewer.SSV.SSV_CameraPanel panel)
        {
            this.Controls.Add(panel);
        }

        public void setTitle(String title)
        {
            this.Text = title;
        }
    }
}
