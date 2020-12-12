namespace Algebra_0._0._3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contenedorPrincipal = new System.Windows.Forms.Panel();
            this.panelCANVAS = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.iconMIN2 = new System.Windows.Forms.PictureBox();
            this.iconMIN = new System.Windows.Forms.PictureBox();
            this.iconMAX = new System.Windows.Forms.PictureBox();
            this.iconCERRAR = new System.Windows.Forms.PictureBox();
            this.contenedorPrincipal.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMIN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCERRAR)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedorPrincipal
            // 
            this.contenedorPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.contenedorPrincipal.Controls.Add(this.panelCANVAS);
            this.contenedorPrincipal.Controls.Add(this.panelTitulo);
            this.contenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.contenedorPrincipal.Name = "contenedorPrincipal";
            this.contenedorPrincipal.Size = new System.Drawing.Size(850, 550);
            this.contenedorPrincipal.TabIndex = 0;
            // 
            // panelCANVAS
            // 
            this.panelCANVAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCANVAS.Location = new System.Drawing.Point(0, 38);
            this.panelCANVAS.Name = "panelCANVAS";
            this.panelCANVAS.Size = new System.Drawing.Size(850, 512);
            this.panelCANVAS.TabIndex = 1;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelTitulo.Controls.Add(this.labelTitulo);
            this.panelTitulo.Controls.Add(this.iconMIN2);
            this.panelTitulo.Controls.Add(this.iconMIN);
            this.panelTitulo.Controls.Add(this.iconMAX);
            this.panelTitulo.Controls.Add(this.iconCERRAR);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(850, 38);
            this.panelTitulo.TabIndex = 0;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Snow;
            this.labelTitulo.Location = new System.Drawing.Point(12, 7);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(164, 20);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Interfaz METRO 0.0.3";
            // 
            // iconMIN2
            // 
            this.iconMIN2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMIN2.BackColor = System.Drawing.Color.OrangeRed;
            this.iconMIN2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconMIN2.BackgroundImage")));
            this.iconMIN2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconMIN2.Location = new System.Drawing.Point(725, 7);
            this.iconMIN2.Name = "iconMIN2";
            this.iconMIN2.Size = new System.Drawing.Size(29, 23);
            this.iconMIN2.TabIndex = 4;
            this.iconMIN2.TabStop = false;
            this.iconMIN2.Click += new System.EventHandler(this.iconMIN2_Click);
            // 
            // iconMIN
            // 
            this.iconMIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMIN.BackColor = System.Drawing.Color.Transparent;
            this.iconMIN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconMIN.BackgroundImage")));
            this.iconMIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconMIN.Location = new System.Drawing.Point(766, 7);
            this.iconMIN.Name = "iconMIN";
            this.iconMIN.Size = new System.Drawing.Size(29, 23);
            this.iconMIN.TabIndex = 3;
            this.iconMIN.TabStop = false;
            this.iconMIN.Click += new System.EventHandler(this.iconMIN_Click);
            // 
            // iconMAX
            // 
            this.iconMAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMAX.BackColor = System.Drawing.Color.Transparent;
            this.iconMAX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconMAX.BackgroundImage")));
            this.iconMAX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconMAX.Location = new System.Drawing.Point(766, 7);
            this.iconMAX.Name = "iconMAX";
            this.iconMAX.Size = new System.Drawing.Size(29, 23);
            this.iconMAX.TabIndex = 2;
            this.iconMAX.TabStop = false;
            this.iconMAX.Click += new System.EventHandler(this.iconMAX_Click);
            // 
            // iconCERRAR
            // 
            this.iconCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCERRAR.BackColor = System.Drawing.Color.Transparent;
            this.iconCERRAR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconCERRAR.BackgroundImage")));
            this.iconCERRAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconCERRAR.Location = new System.Drawing.Point(805, 7);
            this.iconCERRAR.Name = "iconCERRAR";
            this.iconCERRAR.Size = new System.Drawing.Size(29, 23);
            this.iconCERRAR.TabIndex = 0;
            this.iconCERRAR.TabStop = false;
            this.iconCERRAR.Click += new System.EventHandler(this.iconCERRAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.contenedorPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contenedorPrincipal.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMIN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCERRAR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedorPrincipal;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox iconCERRAR;
        private System.Windows.Forms.PictureBox iconMAX;
        private System.Windows.Forms.PictureBox iconMIN2;
        private System.Windows.Forms.PictureBox iconMIN;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelCANVAS;
    }
}

