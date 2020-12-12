using MaterialSkin.Controls;
using MaterialSkin;
using System.Drawing;

namespace Algebra_0._0._3
{
    public partial class formREFLEX : MaterialForm
    {
        private Image img;

        private int aux0;
        private int aux1;
        private int aux2;
        private int aux3;

        private SimetriaCuadrado.Simetria auxROT;
        private SimetriaCuadrado.Cuadrado simetriaCuadrado;

        public formREFLEX()
        {
            InitializeComponent();
            // Creando un material theme manager 
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Definindo un esquema 
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Lime900, Primary.Lime900,
                Primary.Grey200, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void formREFLEX_Load(object sender, System.EventArgs e)
        {
          
            this.simetriaCuadrado = new SimetriaCuadrado.Cuadrado(
                this.aux0, this.aux1,
                this.aux2, this.aux3
                );

            this.auxROT = new SimetriaCuadrado.Simetria();    
        }

        private void reflexA_Click(object sender, System.EventArgs e)
        {
            
            this.auxROT = this.simetriaCuadrado.Reflexion('a');

            this.txtRF5.Text = "Salida: " + this.auxROT.Vector[0].Y.ToString();
            this.txtRF6.Text = "Salida: " + this.auxROT.Vector[1].Y.ToString();
            this.txtRF7.Text = "Salida: " + this.auxROT.Vector[2].Y.ToString();
            this.txtRF8.Text = "Salida: " + this.auxROT.Vector[3].Y.ToString();

            this.loadNewPict("cuadrado3.png");

        }

        private void reflexB_Click(object sender, System.EventArgs e)
        {
            this.auxROT = this.simetriaCuadrado.Reflexion('b');

            this.txtRF5.Text = "Salida: " + this.auxROT.Vector[0].Y.ToString();
            this.txtRF6.Text = "Salida: " + this.auxROT.Vector[1].Y.ToString();
            this.txtRF7.Text = "Salida: " + this.auxROT.Vector[2].Y.ToString();
            this.txtRF8.Text = "Salida: " + this.auxROT.Vector[3].Y.ToString();

            this.loadNewPict("cuadrado4.png");
        }

        private void reflexV_Click(object sender, System.EventArgs e)
        {
            this.auxROT = this.simetriaCuadrado.Reflexion('v');

            this.txtRF5.Text = "Salida: " + this.auxROT.Vector[0].Y.ToString();
            this.txtRF6.Text = "Salida: " + this.auxROT.Vector[1].Y.ToString();
            this.txtRF7.Text = "Salida: " + this.auxROT.Vector[2].Y.ToString();
            this.txtRF8.Text = "Salida: " + this.auxROT.Vector[3].Y.ToString();

            this.loadNewPict("cuadro1.png");

        }

        private void reflexH_Click(object sender, System.EventArgs e)
        {
            this.auxROT = this.simetriaCuadrado.Reflexion('h');

            this.txtRF5.Text = "Salida: " + this.auxROT.Vector[0].Y.ToString();
            this.txtRF6.Text = "Salida: " + this.auxROT.Vector[1].Y.ToString();
            this.txtRF7.Text = "Salida: " + this.auxROT.Vector[2].Y.ToString();
            this.txtRF8.Text = "Salida: " + this.auxROT.Vector[3].Y.ToString();

            this.loadNewPict("cuadrado2.png");

        }

        public void getVertices(int[] aux)
        {
            this.aux0 = aux[0];
            this.aux1 = aux[1];
            this.aux2 = aux[2];
            this.aux3 = aux[3];
        }

        private void loadNewPict(string link)
        {
            this.imgPanel.Image = Image.FromFile
            ("img/"+link);
        }

        private void bttOriginal_Click(object sender, System.EventArgs e)
        {
            this.loadNewPict("cuadrado1.png");

            this.txtRF5.Text = "V. Original: " + this.aux0;
            this.txtRF6.Text = "V. Original: " + this.aux1;
            this.txtRF7.Text = "V. Original: " + this.aux2;
            this.txtRF8.Text = "V. Original: " + this.aux3;
        }
    }
}
