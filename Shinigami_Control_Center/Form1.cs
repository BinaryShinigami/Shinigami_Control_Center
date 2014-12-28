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
                addCamera(newCameraDialog.m_URL, newCameraDialog.m_Username, newCameraDialog.m_Password);
            }
        }

        private void addCamera(String url, String username, String password) {
            try {
                Shinigami_Security_Viewer.SSV.SSV_Camera tmpCamera = new Shinigami_Security_Viewer.SSV.SSV_Camera(url, username, password);
                lblStatus.Text = "Attempting to open Camera Stream";
                tmpCamera.startCameraCapture();
                lblStatus.Text = "Camera Opened!";
                numCams++;
                securityCameras.Add(tmpCamera);
                modifyInnterTableForCameras();
                tblInnerTable.Controls.Add(securityCameras[(securityCameras.Count - 1)].getCameraPanel(), currentRow, currentCol-1);
            }
            catch (Exception e) {
                MessageBox.Show("Error! Unable to Add Camera: " + e.ToString());
            }
        }

        private void modifyInnterTableForCameras() {
            if (((numCams % maxCamsPerRow) > 0) && (numCams > maxCamsPerRow))
            {
                tblInnerTable.RowCount++;
                tblInnerTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
                currentRow++;
                currentCol = 0;
            }
            else
            {
                if ((tblInnerTable.ColumnCount < maxCamsPerRow) && numCams > 1)
                {
                    tblInnerTable.ColumnCount++;
                    tblInnerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
                }
                currentCol++;
            }
        }
    }
}
