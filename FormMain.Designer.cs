namespace nrfutilKeyGen
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerateNew = new System.Windows.Forms.Button();
            this.buttonGeneratePublic = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.openFileDialogPrivateKey = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonGenerateNew
            // 
            this.buttonGenerateNew.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateNew.Location = new System.Drawing.Point(78, 61);
            this.buttonGenerateNew.Name = "buttonGenerateNew";
            this.buttonGenerateNew.Size = new System.Drawing.Size(226, 87);
            this.buttonGenerateNew.TabIndex = 0;
            this.buttonGenerateNew.Text = "Generate New Private Key";
            this.buttonGenerateNew.UseVisualStyleBackColor = true;
            this.buttonGenerateNew.Click += new System.EventHandler(this.buttonGenerateNew_Click);
            // 
            // buttonGeneratePublic
            // 
            this.buttonGeneratePublic.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGeneratePublic.Location = new System.Drawing.Point(78, 199);
            this.buttonGeneratePublic.Name = "buttonGeneratePublic";
            this.buttonGeneratePublic.Size = new System.Drawing.Size(302, 131);
            this.buttonGeneratePublic.TabIndex = 1;
            this.buttonGeneratePublic.Text = "Generate Public Key from Private Key";
            this.buttonGeneratePublic.UseVisualStyleBackColor = true;
            this.buttonGeneratePublic.Click += new System.EventHandler(this.buttonGeneratePublic_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(13, 353);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(509, 146);
            this.textBoxLog.TabIndex = 2;
            // 
            // openFileDialogPrivateKey
            // 
            this.openFileDialogPrivateKey.Filter = "Key(*.key)|*.key";
            this.openFileDialogPrivateKey.Title = "Select the Private Key";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonGeneratePublic);
            this.Controls.Add(this.buttonGenerateNew);
            this.Name = "FormMain";
            this.Text = "nrfutilKeyGen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateNew;
        private System.Windows.Forms.Button buttonGeneratePublic;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.OpenFileDialog openFileDialogPrivateKey;
    }
}

