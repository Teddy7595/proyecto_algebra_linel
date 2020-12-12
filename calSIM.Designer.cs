namespace Algebra_0._0._3
{
    partial class calSIM
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
            this.txtEXPRSION = new System.Windows.Forms.TextBox();
            this.bttCAL = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBOX = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtEXPRSION
            // 
            this.txtEXPRSION.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEXPRSION.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEXPRSION.Location = new System.Drawing.Point(12, 78);
            this.txtEXPRSION.Name = "txtEXPRSION";
            this.txtEXPRSION.Size = new System.Drawing.Size(276, 26);
            this.txtEXPRSION.TabIndex = 0;
            // 
            // bttCAL
            // 
            this.bttCAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttCAL.Depth = 0;
            this.bttCAL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCAL.Location = new System.Drawing.Point(12, 248);
            this.bttCAL.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttCAL.Name = "bttCAL";
            this.bttCAL.Primary = true;
            this.bttCAL.Size = new System.Drawing.Size(147, 40);
            this.bttCAL.TabIndex = 1;
            this.bttCAL.Text = "Calcular";
            this.bttCAL.UseVisualStyleBackColor = true;
            this.bttCAL.Click += new System.EventHandler(this.bttCAL_Click);
            // 
            // textBOX
            // 
            this.textBOX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBOX.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBOX.Cursor = System.Windows.Forms.Cursors.Cross;
            this.textBOX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBOX.Location = new System.Drawing.Point(9, 110);
            this.textBOX.Name = "textBOX";
            this.textBOX.ReadOnly = true;
            this.textBOX.Size = new System.Drawing.Size(279, 132);
            this.textBOX.TabIndex = 3;
            this.textBOX.Text = "";
            // 
            // calSIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.textBOX);
            this.Controls.Add(this.bttCAL);
            this.Controls.Add(this.txtEXPRSION);
            this.Name = "calSIM";
            this.Load += new System.EventHandler(this.calSIM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEXPRSION;
        private MaterialSkin.Controls.MaterialRaisedButton bttCAL;
        private System.Windows.Forms.RichTextBox textBOX;
    }
}