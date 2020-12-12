using MaterialSkin.Controls;
using MaterialSkin;
using System.Windows.Forms;

namespace Algebra_0._0._3
{

    public partial class nuevoFORM : MaterialForm
    {
        private int[] aux;
        public nuevoFORM()
        {
            InitializeComponent();
            this.aux = new int[4];
            // Creando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepPurple500, Primary.DeepPurple500,
                Primary.Grey500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void bttLIMPIAR_Click(object sender, System.EventArgs e)
        {
            this.txtVERTICE1.Text = null;
            this.txtVERTICE2.Text = null;
            this.txtVERTICE3.Text = null;
            this.txtVERTICE4.Text = null;
        }

        private void bttGUARDAR_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.aux[0] = int.Parse(this.txtVERTICE2.Text);
                this.aux[1] = int.Parse(this.txtVERTICE3.Text);
                this.aux[2] = int.Parse(this.txtVERTICE4.Text);
                this.aux[3] = int.Parse(this.txtVERTICE1.Text);
                MessageBox.Show("Elementos Guardados Satisfactoriamente", "Calculador Algebra",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch(System.Exception)
            {
                MessageBox.Show("Error, No se puede pasar Elementos Alfábéticos", "Calculador Algebra",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public int[] linkElementos(){return aux;}
    }
}
