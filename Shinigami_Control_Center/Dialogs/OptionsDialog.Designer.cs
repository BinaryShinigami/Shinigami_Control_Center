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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtVideoFolder = new System.Windows.Forms.TextBox();
            this.btnVideoBrowse = new System.Windows.Forms.Button();
            this.cbxAutoRecord = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(187, 151);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(268, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Video Output Resolution:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(143, 55);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(35, 20);
            this.txtWidth.TabIndex = 8;
            this.txtWidth.Text = "1280";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(204, 55);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(34, 20);
            this.txtHeight.TabIndex = 10;
            this.txtHeight.Text = "720";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(312, 90);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(586, 181);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox textBox1;
    }
}