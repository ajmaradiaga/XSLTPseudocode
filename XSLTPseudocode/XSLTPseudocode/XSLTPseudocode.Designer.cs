namespace XSLTPseudocode
{
    partial class XSLTPseudocode
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
            this.txtXSLT = new System.Windows.Forms.TextBox();
            this.btnGeneratePseudocode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtXSLT
            // 
            this.txtXSLT.AcceptsReturn = true;
            this.txtXSLT.AcceptsTab = true;
            this.txtXSLT.Location = new System.Drawing.Point(12, 39);
            this.txtXSLT.Multiline = true;
            this.txtXSLT.Name = "txtXSLT";
            this.txtXSLT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXSLT.Size = new System.Drawing.Size(482, 582);
            this.txtXSLT.TabIndex = 0;
            // 
            // btnGeneratePseudocode
            // 
            this.btnGeneratePseudocode.Location = new System.Drawing.Point(510, 597);
            this.btnGeneratePseudocode.Name = "btnGeneratePseudocode";
            this.btnGeneratePseudocode.Size = new System.Drawing.Size(184, 23);
            this.btnGeneratePseudocode.TabIndex = 1;
            this.btnGeneratePseudocode.Text = "Generate Pseudocode";
            this.btnGeneratePseudocode.UseVisualStyleBackColor = true;
            this.btnGeneratePseudocode.Click += new System.EventHandler(this.btnGeneratePseudocode_Click);
            // 
            // XSLTPseudocode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 633);
            this.Controls.Add(this.btnGeneratePseudocode);
            this.Controls.Add(this.txtXSLT);
            this.Name = "XSLTPseudocode";
            this.Text = "XSLT Pseudocode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXSLT;
        private System.Windows.Forms.Button btnGeneratePseudocode;
    }
}

