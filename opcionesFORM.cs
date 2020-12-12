using System.Drawing;
using System.Windows.Forms;

namespace Algebra_0._0._3
{
    public partial class opcionesFORM : Form
    {
        private bool[] opHIDDEN;
        private bool ifaux;
        private int option;
        private Panel aux;
        private int[] auxInt;


        public opcionesFORM()
        {
            InitializeComponent();
            this.aux = new Panel();
            this.auxInt = new int[4];
            this.option = 0;
            this.opHIDDEN = new bool[5];
            this.opHIDDEN[0] = true;
            this.opHIDDEN[1] = true;
            this.opHIDDEN[2] = true;
            this.opHIDDEN[3] = true;
            this.opHIDDEN[4] = true;
            this.panelGEN.Height = 0;
            this.panelAYUDA.Height = 0;
            this.panelARCHIVO.Height = 0;
            this.panelMOVIMIENTO.Height = 0;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            void controlTIMER(Panel aux)
            {
         
                if (this.ifaux)
                {
                    aux.Height = aux.Height + 4;
                    this.panelSLDMENU.Refresh();
                    if(this.option == 4 || this.option == 5)
                    {
                        if (aux.Height >= 44) { this.timer1.Stop(); this.ifaux = false; }
                    }
                    else
                    {
                        if (aux.Height >= 84) { this.timer1.Stop(); this.ifaux = false; }
                    }
                    
                }
                else
                {
                    aux.Height = aux.Height - 4;
                    if (aux.Height == 0) { this.timer1.Stop(); this.ifaux = true; }
                }
                
            }

            switch (this.option)
            {
                case 1:
                {
                     this.ifaux = this.opHIDDEN[0];
                     controlTIMER(this.panelARCHIVO);
                     this.opHIDDEN[0] = this.ifaux;
                } break;

                case 2:
                {
                     this.ifaux = this.opHIDDEN[1];
                     controlTIMER(this.panelMOVIMIENTO);
                     this.opHIDDEN[1] = this.ifaux;
                }break;

                case 3:
                {
                     
                }break;

                case 4:
                {
                     this.ifaux = this.opHIDDEN[3];
                     controlTIMER(this.panelGEN);
                     this.opHIDDEN[3] = this.ifaux;
                }break;

                case 5:
                {
                     this.ifaux = this.opHIDDEN[4];
                     controlTIMER(this.panelAYUDA);
                     this.opHIDDEN[4] = this.ifaux;
                }break;
            }
            
        }

        private void bttARCHIVO_Click(object sender, System.EventArgs e)
        {
            this.timer1.Start();
            this.option = 1;
        }

        private void bttMOV_Click(object sender, System.EventArgs e)
        {
            this.timer1.Start();
            this.option = 2;
        }

        private void bttCAL_Click(object sender, System.EventArgs e)
        {
            if (this.panelCANVAS1.Controls.Count > 0)
                this.panelCANVAS1.Controls.RemoveAt(0);
            calSIM hijo1 = new calSIM();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelCANVAS1.Controls.Add(hijo1);
            this.panelCANVAS1.Tag = hijo1;
            hijo1.getVertices(this.auxInt);
            hijo1.Show();
        }

        private void bttGEN_Click(object sender, System.EventArgs e)
        {
            this.timer1.Start();
            this.option = 4;
        }

        private void bttAYUDA_Click(object sender, System.EventArgs e)
        {
            this.timer1.Start();
            this.option = 5;
        }

        private void bttNUEVO_Click(object sender, System.EventArgs e)
        {
            if (this.panelCANVAS1.Controls.Count > 0)
                this.panelCANVAS1.Controls.RemoveAt(0);
            nuevoFORM hijo1 = new nuevoFORM();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelCANVAS1.Controls.Add(hijo1);
            this.panelCANVAS1.Tag = hijo1;
            hijo1.Show();

            this.auxInt = hijo1.linkElementos();
            

        }

        private void bttSALIR_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void bttROTACION_Click(object sender, System.EventArgs e)
        {
            if (this.panelCANVAS1.Controls.Count > 0)
                this.panelCANVAS1.Controls.RemoveAt(0);
            formROT hijo1 = new formROT();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelCANVAS1.Controls.Add(hijo1);
            this.panelCANVAS1.Tag = hijo1;
            hijo1.getVertices(this.auxInt);
            hijo1.Show();
            
        }

        private void bttREFLEX_Click(object sender, System.EventArgs e)
        {
            if (this.panelCANVAS1.Controls.Count > 0)
                this.panelCANVAS1.Controls.RemoveAt(0);
            formREFLEX hijo1 = new formREFLEX();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelCANVAS1.Controls.Add(hijo1);
            this.panelCANVAS1.Tag = hijo1;
            hijo1.getVertices(this.auxInt);
            hijo1.Show();
        }

        private void bttSIMETRIA_Click(object sender, System.EventArgs e)
        {
            if (this.panelCANVAS1.Controls.Count > 0)
                this.panelCANVAS1.Controls.RemoveAt(0);
            gSimetria hijo1 = new gSimetria();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelCANVAS1.Controls.Add(hijo1);
            this.panelCANVAS1.Tag = hijo1;
            hijo1.getVertices(this.auxInt);
            hijo1.Show();
        }

        private void bttAUTOR_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Proyecto realizado por : \n Andrés Avila 26.444.330" +
                "\n Teddy Pottellá 25.936.862" +
                "\n Fremin Fernandez 25.852.967"
                , "Calculador de Simetría",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
