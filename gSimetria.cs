using MaterialSkin.Controls;
using MaterialSkin;

namespace Algebra_0._0._3
{
    public partial class gSimetria : MaterialForm
    {
        private int aux0;
        private int aux1;
        private int aux2;
        private int aux3;

        private SimetriaCuadrado.Cuadrado simetriaCuadrado;

        public gSimetria()
        {
            InitializeComponent();
            // Creando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Amber200, Primary.Amber200,
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

        private void gSimetria_Load(object sender, System.EventArgs e)
        {
            
            this.simetriaCuadrado = new SimetriaCuadrado.Cuadrado(
                this.aux0, this.aux1, 
                this.aux2, this.aux3
                );

            this.simetriaCuadrado.GenerarGrupoSimetria();
            this.textBOX.AppendText("\n");

            for(int i =0; i <8; i++)
            {
                this.textBOX.AppendText("     ");
                for (int j = 0; j < 8; j++)
                {
                    this.textBOX.AppendText(this.simetriaCuadrado.
                        GrupoSimetrias[j,i].ID +"   ");
                }
                this.textBOX.AppendText("\n\n");
            }
        }

        private void bttSBGRP_Click(object sender, System.EventArgs e)
        {
            if (this.pADICIONAL.Controls.Count > 0)
                this.pADICIONAL.Controls.RemoveAt(0);
            subgrFORM hijo1 = new subgrFORM();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            hijo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pADICIONAL.Controls.Add(hijo1);
            this.pADICIONAL.Tag = hijo1;
            hijo1.getVertices(this.aux0, this.aux1, this.aux2, this.aux3);
            hijo1.Show();

        }

        private void bttCLATERALES_Click(object sender, System.EventArgs e)
        {
            if (this.pADICIONAL.Controls.Count > 0)
                this.pADICIONAL.Controls.RemoveAt(0);
            cLATERALES hijo1 = new cLATERALES();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            hijo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pADICIONAL.Controls.Add(hijo1);
            this.pADICIONAL.Tag = hijo1;
            hijo1.getVertices(this.aux0, this.aux1, this.aux2, this.aux3);
            hijo1.Show();
        }
    }
}
