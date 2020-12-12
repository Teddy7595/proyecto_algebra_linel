namespace Algebra_0._0._3
{
    partial class subgrFORM
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
            this.cmBOX = new System.Windows.Forms.ComboBox();
            this.bttGENERAR = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBOX = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmBOX
            // 
            this.cmBOX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmBOX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBOX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBOX.FormattingEnabled = true;
            this.cmBOX.Items.AddRange(new object[] {
            "H0",
            "H1",
            "H2",
            "H3",
            "H4",
            "H5",
            "H6",
            "H7"});
            this.cmBOX.Location = new System.Drawing.Point(12, 29);
            this.cmBOX.Name = "cmBOX";
            this.cmBOX.Size = new System.Drawing.Size(80, 26);
            this.cmBOX.TabIndex = 0;
            // 
            // bttGENERAR
            // 
            this.bttGENERAR.AutoSize = true;
            this.bttGENERAR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttGENERAR.Depth = 0;
            this.bttGENERAR.Location = new System.Drawing.Point(174, 24);
            this.bttGENERAR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttGENERAR.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttGENERAR.Name = "bttGENERAR";
            this.bttGENERAR.Primary = false;
            this.bttGENERAR.Size = new System.Drawing.Size(73, 36);
            this.bttGENERAR.TabIndex = 1;
            this.bttGENERAR.Text = "Generar";
            this.bttGENERAR.UseVisualStyleBackColor = true;
            this.bttGENERAR.Click += new System.EventHandler(this.bttGENERAR_Click);
            // 
            // textBOX
            // 
            this.textBOX.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBOX.Cursor = System.Windows.Forms.Cursors.Cross;
            this.textBOX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBOX.Location = new System.Drawing.Point(12, 79);
            this.textBOX.Name = "textBOX";
            this.textBOX.ReadOnly = true;
            this.textBOX.Size = new System.Drawing.Size(235, 230);
            this.textBOX.TabIndex = 2;
            this.textBOX.Text = "";
            // 
            // subgrFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 330);
            this.Controls.Add(this.textBOX);
            this.Controls.Add(this.bttGENERAR);
            this.Controls.Add(this.cmBOX);
            this.MaximizeBox = false;
            this.Name = "subgrFORM";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.subgrFORM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBOX;
        private MaterialSkin.Controls.MaterialFlatButton bttGENERAR;
        private System.Windows.Forms.RichTextBox textBOX;
    }
}