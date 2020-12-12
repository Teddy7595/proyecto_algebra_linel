using MaterialSkin.Controls;
using MaterialSkin;

namespace Algebra_0._0._3
{
    public partial class calSIM : MaterialForm
    {
        private int aux0;
        private int aux1;
        private int aux2;
        private int aux3;
        private bool flag;

        private SimetriaCuadrado.Cuadrado auxCalculo;
        private SimetriaCuadrado.Calculadora calculadora;

        public calSIM()
        {
            InitializeComponent();
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

        public void getVertices(int[] aux)
        {
            this.aux0 = aux[0];
            this.aux1 = aux[1];
            this.aux2 = aux[2];
            this.aux3 = aux[3];
        }

        private void calSIM_Load(object sender, System.EventArgs e)
        {
            this.auxCalculo = new SimetriaCuadrado.Cuadrado(
                this.aux0, this.aux1, this.aux2, this.aux3
                );

            this.calculadora = new SimetriaCuadrado.Calculadora(this.auxCalculo);

            this.flag = false;

            this.textBOX.AppendText("                           " +
                "                           Calculadora de Simetría \n\n");
            this.textBOX.AppendText("   Por favor introduzca la expresión a calcula : \n\n");
        }

        private void bttCAL_Click(object sender, System.EventArgs e)
        {
            this.textBOX.Clear();

            this.textBOX.AppendText("                           " +
                "                           Calculadora de Simetría \n\n");
            this.textBOX.AppendText("   Por favor introduzca la expresión a calcula : \n\n");

            SimetriaCuadrado.Simetria aux = new SimetriaCuadrado.Simetria();

            aux = this.calculadora.EvaluarExpresion(
                this.txtEXPRSION.Text, ref this.flag
                );

            if(this.flag)
            {
                this.textBOX.AppendText("Expresion : " + this.txtEXPRSION.Text + "\n\n");
                this.txtEXPRSION.Text = "";
                this.textBOX.AppendText("Resultado : " + aux.ID);
            }
            else
            {
                this.textBOX.AppendText("ERROR EN LA EXPRESION, " +
                    "VERIFIQUE Y REPITA LA OPERACIÓN");
            }
        }
    }
}
