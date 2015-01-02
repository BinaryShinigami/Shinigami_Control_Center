namespace Shinigami_Control_Center.Dialogs
{
    partial class OptionsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtVideoFolder = new System.Windows.Forms.TextBox();
            this.btnVideoBrowse = new System.Windows.Forms.Button();
            this.cbxAutoRecord = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video Output Folder:";
            // 
            // txtVideoFolder
            // 
            this.txtVideoFolder.Location = new System.Drawing.Point(122, 6);
            this.txtVideoFolder.Name = "txtVideoFolder";
            this.txtVideoFolder.Size = new System.Drawing.Size(369, 20);
            this.txtVideoFolder.TabIndex = 1;
            // 
            // btnVideoBrowse
            // 
            this.btnVideoBrowse.Location = new System.Drawing.Point(499, 3);
            this.btnVideoBrowse.Name = "btnVideoBrowse";
            this.btnVideoBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnVideoBrowse.TabIndex = 2;
            this.btnVideoBrowse.Text = "Browse";
            this.btnVideoBrowse.UseVisualStyleBackColor = true;
            this.btnVideoBrowse.Click += new System.EventHandler(this.btnVideoBrowse_Click);
            // 
            // cbxAutoRecord
            // 
            this.cbxAutoRecord.AutoSize = true;
            this.cbxAutoRecord.Location = new System.Drawing.Point(15, 38);
            this.cbxAutoRecord.Name = "cbxAutoRecord";
            this.cbxAutoRecord.Size = new System.Drawing.Size(195, 17);
            this.cbxAutoRecord.TabIndex = 4;
            this.cbxAutoRecord.Text = "Automatically Start Recording Video";
            this.cbxAutoRecord.UseVisualStyleBackColor = true;
            this.cbxAutoRecord.CheckedChanged += new System.EventHandler(this.cbxAutoRecord_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(229, 63);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(310, 63);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(586, 98);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxAutoRecord);
            this.Controls.Add(this.btnVideoBrowse);
            this.Controls.Add(this.txtVideoFolder);
            this.Controls.Add(this.label1);
            this.Name = "OptionsDialog";
            this.Text = "OptionsDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtVideoFolder;
        private System.Windows.Forms.Button btnVideoBrowse;
        private System.Windows.Forms.CheckBox cbxAutoRecord;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}