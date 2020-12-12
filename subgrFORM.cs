using MaterialSkin.Controls;
using MaterialSkin;
using System.Windows.Forms;

namespace Algebra_0._0._3
{
    public partial class subgrFORM : MaterialForm
    {
        private int aux0;
        private int aux1;
        private int aux2;
        private int aux3;
        private SimetriaCuadrado.Cuadrado simetriaCuadrado;

        public subgrFORM()
        {
            InitializeComponent();
            this.cmBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            // Creando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue600,
                Primary.Grey200, Accent.LightBlue200,
                TextShade.WHITE);
        }
        public void getVertices(int aux0,int aux1, int aux2, int aux3)
        {
            this.aux0 = aux0;
            this.aux1 = aux1;
            this.aux2 = aux2;
            this.aux3 = aux3;
        }

        private void subgrFORM_Load(object sender, System.EventArgs e)
        {
            this.simetriaCuadrado = new SimetriaCuadrado.Cuadrado(
                this.aux0, this.aux1, this.aux2, this.aux3
                );

            this.simetriaCuadrado.GenerarSubgrupos();
        }

        private void bttGENERAR_Click(object sender, System.EventArgs e)
        {
            this.textBOX.Clear();

            this.simetriaCuadrado.LstSubgrupo[this.cmBOX.SelectedIndex].OperarSimetria();

            this.textBOX.AppendText("\n");
            for (int i =0; i < this.simetriaCuadrado.
                LstSubgrupo[this.cmBOX.SelectedIndex].elementos.GetLength(0); i++)
            {
                this.textBOX.AppendText("     ");
                for (int j = 0; j < this.simetriaCuadrado.
                LstSubgrupo[this.cmBOX.SelectedIndex].elementos.GetLength(1); j++)
                {
                    this.simetriaCuadrado.LstSubgrupo
                        [this.cmBOX.SelectedIndex].
                            elementos[i, j].ID = this.simetriaCuadrado.IdentificarSimetria(
                                this.simetriaCuadrado.LstSubgrupo
                                    [this.cmBOX.SelectedIndex].elementos[i,j]  
                                );

                    this.textBOX.AppendText(

                        this.simetriaCuadrado.LstSubgrupo
                        [this.cmBOX.SelectedIndex].
                            elementos[i, j].ID + " "

                        );
                }
                this.textBOX.AppendText("\n\n");
            }

            string aux = "";
            this.textBOX.AppendText("\n");

            for (int i = 0; i < this.simetriaCuadrado.
                LstSubgrupo[this.cmBOX.SelectedIndex].elementos.GetLength(0); i++)
            {

                aux = this.simetriaCuadrado.LstSubgrupo
                        [this.cmBOX.SelectedIndex].simetrias[i].ID + "   " + aux;
            }
            this.textBOX.AppendText("           ||||OPERADORES|||| \n\n");
            this.textBOX.AppendText(" Superior : { " + aux + " }\n\n");

            aux = "";

            for (int j = 0; j < this.simetriaCuadrado.
                LstSubgrupo[this.cmBOX.SelectedIndex].elementos.GetLength(1); j++)
            {

                aux = this.simetriaCuadrado.LstSubgrupo
                        [this.cmBOX.SelectedIndex].simetrias[j].ID + "   " + aux;
            }
            this.textBOX.AppendText(" Lat. Izq. : { " + aux + " }\n\n");

        }
    }
}
