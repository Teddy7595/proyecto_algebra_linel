using System.Collections.Generic;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Algebra_0._0._3
{
    public partial class cLATERALES : MaterialForm
    {
        private int aux0;
        private int aux1;
        private int aux2;
        private int aux3;
        private SimetriaCuadrado.Cuadrado simetriaCuadrado;
        private List<SimetriaCuadrado.ClasesLaterales> classLateral;

        public cLATERALES()
        {

            InitializeComponent();

            // Creando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo400, Primary.Indigo400,
                Primary.Grey50, Accent.LightBlue200,
                TextShade.WHITE);
        }

        public void getVertices(int aux0, int aux1, int aux2, int aux3)
        {
            this.aux0 = aux0;
            this.aux1 = aux1;
            this.aux2 = aux2;
            this.aux3 = aux3;
        }

        private void cLATERALES_Load(object sender, System.EventArgs e)
        {
            this.classLateral = new List<SimetriaCuadrado.ClasesLaterales>();
            this.simetriaCuadrado = new SimetriaCuadrado.Cuadrado(
                this.aux0, this.aux1, this.aux2, this.aux3
                );
        }

        private void bttGENERAR_Click(object sender, System.EventArgs e)
        {
            this.textBOX.Clear();
            string aux = "";
            this.classLateral = this.simetriaCuadrado.
                CrearClasesLaterales(this.cmBOX.SelectedIndex);
            this.textBOX.AppendText("       Clase lateral H" + 
                this.cmBOX.SelectedIndex + ": \n\n");

            for (int i =0; i < this.classLateral.Count; i++)
            {
                this.textBOX.AppendText("   " + this.classLateral[i].ID+" : ");
       
                for (int j =0; j < this.classLateral[i].Simetrias.Count; j++)
                {
                    aux = this.classLateral[i].Simetrias[j].ID + " " + aux;
                }
                this.textBOX.AppendText("   { " + aux + " }\n\n");
            }
        }
    }
}
