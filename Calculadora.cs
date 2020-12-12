using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimetriaCuadrado
{
    class Calculadora
    {
        Cuadrado Cuad { get; set; }
        const string Operadores = "()O{}[]";
        string[] Operandos;


        public Calculadora(Cuadrado pCuad)
        {
            Cuad = pCuad;

            Operandos = new string[Cuad.Simetrias.Length];
            for (int i = 0; i < Operandos.Length; i++)
            {
                Operandos[i] = Cuad.Simetrias[i].ID;
            }
        }

        public Simetria EvaluarExpresion(string entrada, ref bool flag)
        {
            List<string> postf = PostFijo(entrada, ref flag);
            Simetria op1, op2, aux;

            if (flag)
            {
                for(int i = 0; i < postf.Count; i++)
                {
                    if(postf[i] == "O")
                    {
                        op1 = Cuad.ObtenerSimetria(postf[i - 2]);
                        op2 = Cuad.ObtenerSimetria(postf[i - 1]);

                        aux = op1.Composicion(op2);
                        aux.ID = Cuad.IdentificarSimetria(aux);

                        postf[i] = aux.ID;
                        postf.RemoveAt(i - 1);
                        postf.RemoveAt(i - 2);
                        i = 0;
                    }
                }
            }
            else
            {
                return null;
            }

            flag = true;
            return Cuad.ObtenerSimetria(postf[0]);
        }

        private List<string> PostFijo(string entrada, ref bool flag)
        {

            string buffer = string.Empty;
            Stack<string> pila = new Stack<string>();
            List<string> resultado = new List<string>();
            string apertura = string.Empty;

            // Colocamos todo en mayusculas
            entrada = entrada.ToUpper();
            // Eliminamos los espacios en blanco
            entrada = entrada.Replace(" ", string.Empty);

            for (int i = 0; i < entrada.Length; i++)
            {

                buffer += entrada[i].ToString();

                if (buffer.Length >= 3)
                {
                    break;
                }

                if (Operadores.Contains(buffer))
                {
                    if (buffer == ")" || buffer == "}" || buffer == "]")
                    {
                        switch (buffer)
                        {
                            case ")":
                                apertura = "(";
                                break;

                            case "]":
                                apertura = "[";
                                break;

                            case "}":
                                apertura = "{";
                                break;
                        }

                        while (pila.Peek() != apertura)
                        {
                            resultado.Add(pila.Pop());
                        }
                        pila.Pop();

                    }
                    else
                    {
                        pila.Push(buffer);
                    }

                    buffer = string.Empty;

                }
                else if (Operandos.Contains<string>(buffer))
                {
                    resultado.Add(buffer);
                    buffer = string.Empty;

                }
            }

            if (buffer.Length != 0)
            {
                flag = false;
            }
            else
            {
                foreach (string dato in pila)
                {
                    resultado.Add(dato);
                }

                pila.Clear();

                flag = true;
            }

            return resultado;
        }




    }
}
