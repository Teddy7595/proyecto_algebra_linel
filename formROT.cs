using MaterialSkin.Controls;
using MaterialSkin;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Algebra_0._0._3
{
    public partial class formROT : MaterialForm
    {
        private Image img;
        private int angle;

        private int aux0;
        private int aux1;
        private int aux2;
        private int aux3;

        private SimetriaCuadrado.Simetria auxROT;
        private SimetriaCuadrado.Cuadrado simetriaCuadrado;

        public formROT()
        {
            InitializeComponent();
            this.angle = 0;
            // Creando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepOrange900, Primary.DeepOrange900,
                Primary.Grey50, Accent.LightBlue200,
                TextShade.WHITE);
        }

        
        private void formROT_Load(object sender, System.EventArgs e)
        {
            this.img = Image.FromFile("img/cuadrado1.png");

            this.simetriaCuadrado = new SimetriaCuadrado.Cuadrado(
                this.aux0, this.aux1,
                this.aux2, this.aux3
                );

            this.txtGRADO.Text = "0° Grados";
            this.auxROT = new SimetriaCuadrado.Simetria();
            this.auxROT = this.simetriaCuadrado.Rotar(0);

            this.txtRT5.Text = "Salida: " + this.auxROT.Vector[0].Y.ToString();
            this.txtRT6.Text = "Salida: " + this.auxROT.Vector[1].Y.ToString();
            this.txtRT7.Text = "Salida: " + this.auxROT.Vector[2].Y.ToString();
            this.txtRT8.Text = "Salida: " + this.auxROT.Vector[3].Y.ToString();


        }

        private void formROT_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelROTAR_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.img.Width, this.img.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            
            graphics.TranslateTransform(bitmap.Width/2, bitmap.Height/2);
            graphics.RotateTransform(this.angle *90);
            graphics.TranslateTransform(-bitmap.Width/2, -bitmap.Height/2);
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            graphics.DrawImage(this.img, 0,0);
             e.Graphics.DrawImage(bitmap, bitmap.Width/8, bitmap.Height/12);
        }

        private void trackBar_ValueChanged(object sender, System.EventArgs e)
        {

            this.angle = this.trckROT.Value;
            this.txtGRADO.Text = (this.trckROT.Value *90).ToString() +  "° Grados";

            this.auxROT = new SimetriaCuadrado.Simetria();
            this.auxROT = this.simetriaCuadrado.Rotar(this.trckROT.Value * 90);

            this.panelROTAR.Refresh();

            this.txtRT5.Text = "Salida: " + this.auxROT.Vector[0].Y.ToString();
            this.txtRT6.Text = "Salida: " + this.auxROT.Vector[1].Y.ToString();
            this.txtRT7.Text = "Salida: " + this.auxROT.Vector[2].Y.ToString();
            this.txtRT8.Text = "Salida: " + this.auxROT.Vector[3].Y.ToString();

            Invalidate();
        }

        private void panelROTAR_Resize(object sender, System.EventArgs e)
        {
            Invalidate();
        }

        private void trckROT_Scroll(object sender, System.EventArgs e)
        {
            this.angle = this.trckROT.Value;
            Invalidate();
        }

        public void getVertices(int[] aux)
        {
            this.aux0 = aux[0];
            this.aux1 = aux[1];
            this.aux2 = aux[2];
            this.aux3 = aux[3];
        }

    }
}
