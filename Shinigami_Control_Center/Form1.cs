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
                //securityCameras.Add(tmpCamera);
                createCameraViewerForm(tmpCamera);
                
            }
            catch (Exception e) {
                MessageBox.Show("Error! Unable to Add Camera: " + e.ToString());
            }
        }

        private void createCameraViewerForm(Shinigami_Security_Viewer.SSV.SSV_Camera cameraObject)
        {

            CameraView childForm = new CameraView(cameraObject);
            childForm.MdiParent = this;

            childForm.FormClosing += new FormClosingEventHandler(closeCameraViewEvent);

            childForm.Show();

        }

        private void updateMDIWindowList()
        {
            ActivateMdiChild(null);
            ActivateMdiChild(this.ActiveMdiChild);
        }

        private void closeCameraViewEvent(object source, FormClosingEventArgs eventArgs)
        {
            CameraView src = (CameraView) source;

            if (src.m_Camera.m_RecordingStatus)
            {
                src.m_Camera.stopVideoOutput();
            }

            src.m_Camera.stopCameraCapture();

        }

    }
}
