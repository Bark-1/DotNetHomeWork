
namespace WindowsForms1
{
    partial class FormResult
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
            this.textBoxSuccess = new System.Windows.Forms.TextBox();
            this.textBoxFail = new System.Windows.Forms.TextBox();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.labelFail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSuccess
            // 
            this.textBoxSuccess.Location = new System.Drawing.Point(37, 67);
            this.textBoxSuccess.Multiline = true;
            this.textBoxSuccess.Name = "textBoxSuccess";
            this.textBoxSuccess.Size = new System.Drawing.Size(537, 612);
            this.textBoxSuccess.TabIndex = 0;
            // 
            // textBoxFail
            // 
            this.textBoxFail.Location = new System.Drawing.Point(601, 67);
            this.textBoxFail.Multiline = true;
            this.textBoxFail.Name = "textBoxFail";
            this.textBoxFail.Size = new System.Drawing.Size(541, 612);
            this.textBoxFail.TabIndex = 1;
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Location = new System.Drawing.Point(33, 29);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(106, 24);
            this.labelSuccess.TabIndex = 2;
            this.labelSuccess.Text = "Success:";
            // 
            // labelFail
            // 
            this.labelFail.AutoSize = true;
            this.labelFail.Location = new System.Drawing.Point(597, 29);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(106, 24);
            this.labelFail.TabIndex = 3;
            this.labelFail.Text = "Failure:";
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 709);
            this.Controls.Add(this.labelFail);
            this.Controls.Add(this.labelSuccess);
            this.Controls.Add(this.textBoxFail);
            this.Controls.Add(this.textBoxSuccess);
            this.MaximumSize = new System.Drawing.Size(1207, 780);
            this.MinimumSize = new System.Drawing.Size(1207, 780);
            this.Name = "FormResult";
            this.Text = "FormResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSuccess;
        private System.Windows.Forms.TextBox textBoxFail;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.Label labelFail;
    }
}