using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimetriaCuadrado
{
    class Subgrupo
    {
        public string ID { get; set; }
        public Simetria[] simetrias { get; set; }
        public Simetria[,] elementos { get; set; }
        public Simetria neutro { get; set; }

        public Subgrupo(Simetria pSim)
        {
            neutro = Simetria.GenerarNeutro(pSim);
            GenerarSimetria(pSim);

            elementos = new Simetria[simetrias.Length, simetrias.Length];
            for(int i = 0; i < simetrias.Length; i++){
                for(int j = 0; j < simetrias.Length; j++){
                    elementos[i, j] = new Simetria();
                }
            }   
        }

        public Subgrupo(Simetria[] pSim)
        {
            simetrias = pSim;
            neutro = Simetria.GenerarNeutro(pSim[0]);

            elementos = new Simetria[simetrias.Length, simetrias.Length];
            for (int i = 0; i < simetrias.Length; i++)
            {
                for (int j = 0; j < simetrias.Length; j++)
                {
                    elementos[i, j] = new Simetria();
                }
            }
        }

        public Subgrupo()
        {
            ID = string.Empty;
        }

        public void GenerarSimetria(Simetria pSim)
        {
            List<Simetria> lstSimetria = new List<Simetria>();
            int potencia = 2;

            lstSimetria.Add(neutro);
            lstSimetria.Add(pSim);

            do
            {
                Simetria auxiliar = pSim.Copia();

                for(int i = potencia; i > 1; i--)
                {
                    auxiliar = auxiliar.Composicion(pSim);
                }

                lstSimetria.Add(auxiliar);

                potencia++;

            } while (!lstSimetria[potencia-1].Igual(neutro));

            lstSimetria.RemoveAt(potencia - 1);

            this.simetrias = lstSimetria.ToArray();

        }

        public void OperarSimetria()
        {

            for (int i = 0; i < simetrias.Length; i++)
            {
                for (int j = 0; j < simetrias.Length; j++)
                {
                    elementos[i, j] = simetrias[i].Composicion(simetrias[j]);
                }
            }

        }

    }
}
