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
            this.txtPseudocode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnGeneratePseudocode.Location = new System.Drawing.Point(12, 627);
            this.btnGeneratePseudocode.Name = "btnGeneratePseudocode";
            this.btnGeneratePseudocode.Size = new System.Drawing.Size(184, 33);
            this.btnGeneratePseudocode.TabIndex = 1;
            this.btnGeneratePseudocode.Text = "Generate Pseudocode";
            this.btnGeneratePseudocode.UseVisualStyleBackColor = true;
            this.btnGeneratePseudocode.Click += new System.EventHandler(this.btnGeneratePseudocode_Click);
            // 
            // txtPseudocode
            // 
            this.txtPseudocode.AcceptsReturn = true;
            this.txtPseudocode.AcceptsTab = true;
            this.txtPseudocode.Location = new System.Drawing.Point(528, 39);
            this.txtPseudocode.Multiline = true;
            this.txtPseudocode.Name = "txtPseudocode";
            this.txtPseudocode.ReadOnly = true;
            this.txtPseudocode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPseudocode.Size = new System.Drawing.Size(482, 582);
            this.txtPseudocode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pseudocode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "XSLT";
            // 
            // XSLTPseudocode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 672);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPseudocode);
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
        private System.Windows.Forms.TextBox txtPseudocode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

