using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimetriaCuadrado
{
    class Simetria
    {
        public string ID { get; set; }
        public Point[] Vector { get; set; }

        public Simetria()
        {
            Vector = new Point[Cuadrado.cantVertices];
            for(int i = 0; i < Cuadrado.cantVertices; i++){
                Vector[i] = new Point();
            }
        }

        public Simetria Composicion(Simetria pSim)
        {
            Simetria resultado = new Simetria();

            for(int i = 0; i < Vector.Length; i++)
            {
                for(int j = 0; j < pSim.Vector.Length; j++)
                {
                    if(this.Vector[i].Y == pSim.Vector[j].X)
                    {
                        resultado.Vector[i].X = this.Vector[i].X;
                        resultado.Vector[i].Y = pSim.Vector[j].Y;
                        break;
                    }
                }
            }
            return resultado;
        }

        public bool Igual(Simetria pSimetria)
        {
            bool refIgual;
            int contador = 0;

            if (this.Vector.Equals(pSimetria.Vector))
            {
                refIgual = true;
            }
            else
            {
                refIgual = false;
            }

            if (refIgual)
            {
                return refIgual;

            }
            else
            {
                for(int i = 0; i < Vector.Length; i++)
                {
                    for(int j = 0; j < Vector.Length; j++)
                    {
                        if (this.Vector[i].Equals(pSimetria.Vector[j]))
                        {
                            contador++;
                            break;
                        }
                    }
                }

                if(contador == 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        } // Fin funcion

        public Simetria Copia()
        {
            Simetria resultado = new Simetria();

            resultado.ID = this.ID;
            
            for(int i = 0; i < this.Vector.Length; i++)
            {
                resultado.Vector[i].X = this.Vector[i].X;
                resultado.Vector[i].Y = this.Vector[i].Y;
            }

            return resultado;
        }

        public static Simetria GenerarNeutro(Simetria pSim)
        {
            Simetria neutro = new Simetria();

            neutro.ID = "F0";

            for(int i = 0; i < neutro.Vector.Length; i++)
            {
                neutro.Vector[i].X = neutro.Vector[i].Y = pSim.Vector[i].X;
            }

            return neutro;
        }

    }
}
