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
    public partial class OptionsDialog : Form
    {

        public string m_OutputFolder;
        public Boolean m_AutoRecord;
        public int m_OutputVideoWidth;
        public int m_OutputVideoHeight;

        public OptionsDialog(string outputFolder, Boolean autoRec, int videoWidth, int videoHeight)
        {
            InitializeComponent();
            
            txtVideoFolder.Text = outputFolder;
            m_OutputFolder = outputFolder;

            m_AutoRecord = autoRec;
            cbxAutoRecord.Checked = autoRec;

            m_OutputVideoHeight = videoHeight;
            m_OutputVideoWidth = videoWidth;
            txtHeight.Text = m_OutputVideoHeight.ToString();
            txtWidth.Text = m_OutputVideoWidth.ToString();
        }

        private void btnVideoBrowse_Click(object sender, EventArgs e)
        {
            DialogResult res = folderBrowserDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                m_OutputFolder = folderBrowserDialog1.SelectedPath;
                txtVideoFolder.Text = m_OutputFolder;
            }
        }

        private void cbxAutoRecord_CheckedChanged(object sender, EventArgs e)
        {
            m_AutoRecord = cbxAutoRecord.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            m_OutputFolder = txtVideoFolder.Text + "\\";
            m_AutoRecord = cbxAutoRecord.Checked;

            m_OutputVideoHeight = int.Parse(txtHeight.Text);
            m_OutputVideoWidth = int.Parse(txtWidth.Text);
        }
    }
}
