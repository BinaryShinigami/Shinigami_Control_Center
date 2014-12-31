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
    public partial class frmControlCenterMain : Form
    {
        private int numCams = 0;
        private int maxCamsPerRow = 4;
        private int currentRow = 0;
        private int currentCol = 0;
        private List<Shinigami_Security_Viewer.SSV.SSV_Camera> securityCameras = new List<Shinigami_Security_Viewer.SSV.SSV_Camera>();

        public frmControlCenterMain()
        {
            InitializeComponent();
        }

        private void addCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialogs.NewCameraDialog newCameraDialog = new Dialogs.NewCameraDialog();
            DialogResult res = newCameraDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                addCamera(newCameraDialog.m_URL, newCameraDialog.m_Username, newCameraDialog.m_Password, newCameraDialog.m_CameraName);
            }
        }

        private void addCamera(String url, String username, String password, String cameraName) {
            try {
                Shinigami_Security_Viewer.SSV.SSV_Camera tmpCamera = new Shinigami_Security_Viewer.SSV.SSV_Camera(url, username, password);
                tmpCamera.m_CameraName = cameraName;
                lblStatus.Text = "Attempting to open Camera Stream";
                tmpCamera.startCameraCapture();
                lblStatus.Text = "Camera Opened!";
                numCams++;
                tmpCamera.m_CameraId = numCams;
                securityCameras.Add(tmpCamera);
                createCameraViewerForm(tmpCamera);
                
            }
            catch (Exception e) {
                MessageBox.Show("Error! Unable to Add Camera: " + e.ToString());
            }
        }

        private void createCameraViewerForm(Shinigami_Security_Viewer.SSV.SSV_Camera cameraObject)
        {

            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = cameraObject.m_CameraName;

            childForm.Controls.Add(cameraObject.getCameraPanel());

            childForm.Show();

        }

    }
}
