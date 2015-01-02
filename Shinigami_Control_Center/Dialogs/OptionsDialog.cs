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

        public OptionsDialog(string outputFolder, Boolean autoRec)
        {
            InitializeComponent();
            
            txtVideoFolder.Text = outputFolder;
            m_OutputFolder = outputFolder;

            m_AutoRecord = autoRec;
            cbxAutoRecord.Checked = autoRec;
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

        }
    }
}
