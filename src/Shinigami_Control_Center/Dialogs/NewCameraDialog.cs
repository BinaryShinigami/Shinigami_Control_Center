using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shinigami_Control_Center.Dialogs
{
    public partial class NewCameraDialog : Form
    {

        public String m_URL;
        public String m_Username;
        public String m_Password;
        public String m_CameraName;

        public NewCameraDialog()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            m_URL = txtURL.Text;
            m_Username = txtUsername.Text;
            m_Password = txtPassword.Text;
            m_CameraName = txtCameraName.Text;

        }
    }
}
