using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimetriaCuadrado
{

    struct ClasesLaterales
    {
        public String ID {get; set;}
        public List<Simetria> Simetrias {get; set;}

    }


    class Cuadrado
    {
        public int[] Vertices { get; set; }
        public Simetria[] Simetrias { get; set; }
        public Simetria[,] GrupoSimetrias { get; set; }
        public List<ClasesLaterales> laterales  { get; set; }
        public List<Subgrupo> LstSubgrupo { get; set; } 
        public const int cantVertices = 4;
        public const int cantSimetrias = 8;

        public Cuadrado(int ver1, int ver2, int ver3, int ver4){

            Vertices = new int[cantVertices];
            for(int i = 0; i < cantVertices; i++){
                Vertices[i] = new int();
            }
            Vertices[0] = ver1;
            Vertices[1] = ver2;
            Vertices[2] = ver3;
            Vertices[3] = ver4;

            Simetrias = new Simetria[cantSimetrias];

            Simetrias[0] = Rotar(0);
            Simetrias[1] = Rotar(90);
            Simetrias[2] = Rotar(180);
            Simetrias[3] = Rotar(270);

            Simetrias[4] = Reflexion('v');
            Simetrias[5] = Reflexion('h');
            Simetrias[6] = Reflexion('a');
            Simetrias[7] = Reflexion('b');

            for (int i = 0; i < cantSimetrias; i++)
            {
                Simetrias[i].ID = "F" + i;
            }

            GrupoSimetrias = new Simetria[cantSimetrias, cantSimetrias]; 
            for(int i = 0; i < cantSimetrias; i++){
                for(int j = 0; j < cantSimetrias; j++){
                    GrupoSimetrias[i,j] = new Simetria();
                }
            }

            LstSubgrupo = new List<Subgrupo>();

            laterales = new List<ClasesLaterales>();
        }

        public Simetria Rotar(int angulo){

            Simetria sim = new Simetria();
            int[] nuevaPos = new int[cantVertices];
            int traslacion = angulo / 90;
            int movimiento;

            for(int i = 0; i < sim.Vector.Length; i++){
                sim.Vector[i].X = Vertices[i];
            }

            if(traslacion != 0){

                for(int i = 0; i < nuevaPos.Length; i++){
                   
                    movimiento = i;
                    for(int j = 0; j < traslacion; j++){
                        movimiento++;
                    }

                    if(movimiento >= cantVertices){
                        movimiento %= cantVertices;
                    }

                    nuevaPos[movimiento] = Vertices[i];
                }

                for(int i = 0; i < sim.Vector.Length; i++){
                    sim.Vector[i].Y = nuevaPos[i];
                }

            }else{
                for(int i = 0; i < sim.Vector.Length; i++){
                    sim.Vector[i].Y = Vertices[i];
                }
            }

            return sim;
        }

        public Simetria Reflexion(char reflex){

            int[] nuevaPos = new int[cantVertices];
            Simetria sim = new Simetria();

            for(int i = 0; i < sim.Vector.Length; i++){
                sim.Vector[i].X = Vertices[i];
            }

            switch(reflex){

                case 'v':
                    sim.Vector[0].Y = Vertices[3];
                    sim.Vector[1].Y = Vertices[2];
                    sim.Vector[2].Y = Vertices[1];
                    sim.Vector[3].Y = Vertices[0];                    

                    break;

                case 'h':
                    sim.Vector[0].Y = Vertices[1];
                    sim.Vector[1].Y = Vertices[0];
                    sim.Vector[2].Y = Vertices[3];
                    sim.Vector[3].Y = Vertices[2];                    

                    break;
                    
                case 'a':
                    sim.Vector[0].Y = Vertices[0];
                    sim.Vector[1].Y = Vertices[3];
                    sim.Vector[2].Y = Vertices[2];
                    sim.Vector[3].Y = Vertices[1];                    

                    break;

                case 'b':
                    sim.Vector[0].Y = Vertices[2];
                    sim.Vector[1].Y = Vertices[1];
                    sim.Vector[2].Y = Vertices[0];
                    sim.Vector[3].Y = Vertices[3];                    

                    break;                                                            
            }

            return sim;
        }

        public void GenerarGrupoSimetria(){

            for(int i = 0; i < cantSimetrias ; i++)
            {
                for(int j = 0; j < cantSimetrias; j++)
                {
                    GrupoSimetrias[i, j] = Simetrias[i].Composicion(Simetrias[j]);
                    GrupoSimetrias[i, j].ID = IdentificarSimetria(GrupoSimetrias[i, j]);
                }
            }

        }

        public String IdentificarSimetria(Simetria pSim){

            bool equal;

            for(int i = 0; i < Simetrias.Length; i++)
            {
                equal = true; 

                for(int j = 0; j < Simetrias[i].Vector.Length; j++)
                {
                    if(pSim.Vector[j].Y != Simetrias[i].Vector[j].Y)
                    {
                        equal = false;
                        break;
                    }
                }

                if (equal)
                {
                    return Simetrias[i].ID;
                }
                
            }
            return string.Empty;
        }

        public Simetria[] IdentificarSimetria(Simetria[] pSim){
            
            for(int i = 0; i < pSim.Length; i++){
                pSim[i].ID = IdentificarSimetria(pSim[i]);
            }
            return pSim;
        }

        public Simetria ObtenerSimetria(String id){

            for(int i = 0; i < Simetrias.Length; i++){
                if(Simetrias[i].ID.CompareTo(id) == 0){
                    return Simetrias[i];
                }
            }

            return null;
        }

        public void GenerarSubgrupos()
        {
            for (int i = 0; i < Simetrias.Length + 1; i++)
            {
                LstSubgrupo.Add(CrearSubgrupo(i));
                LstSubgrupo[i].simetrias = OrdenarSimetrias(LstSubgrupo[i].simetrias);
            }
            DepurarSubgrupos();
        }

        private Subgrupo CrearSubgrupo(int num){

            if(num == 0)
            {
                Subgrupo sub = new Subgrupo
                {
                    ID = "H" + num
                };

                sub.elementos = new Simetria[1, 1];
                sub.elementos[0, 0] = Simetrias[0];

                sub.simetrias = new Simetria[1];
                sub.simetrias[0] = Simetrias[0];

                sub.neutro = Simetrias[0];

                return sub;
            }
            else if(num == 8)
            {
                Subgrupo sub = new Subgrupo
                {
                    ID = "H" + num
                };

                GenerarGrupoSimetria();
                sub.elementos = GrupoSimetrias;

                sub.simetrias = Simetrias;

                sub.neutro = Simetrias[0];

                return sub;
            }
            else
            {
                Subgrupo sub = new Subgrupo(Simetrias[num])
                {
                    ID = "H" + num
                };

                for (int i = 0; i < sub.simetrias.Length; i++)
                {
                    sub.simetrias[i].ID = IdentificarSimetria(sub.simetrias[i]);
                }

                return sub;
            }

        }

        private void DepurarSubgrupos()
        {
            int cambio = 0;
            int tamanoOriginal = LstSubgrupo.Count;

            for(int i = 0; i < LstSubgrupo.Count; i++)
            {
                for(int j = i + 1; j < LstSubgrupo.Count; j++)
                {
                    if(LstSubgrupo[i].simetrias.Length == LstSubgrupo[j].simetrias.Length)
                    {
                       for(int k = 0; k < LstSubgrupo[i].simetrias.Length; k++)
                        {
                            if (!(LstSubgrupo[i].simetrias[k].Igual(LstSubgrupo[j].simetrias[k])))
                            {
                                break;
                            }
                            else
                            {
                                cambio++;
                            }

                        }
                    }
                    if(cambio == LstSubgrupo[i].simetrias.Length)
                    {
                        LstSubgrupo.RemoveAt(j);
                    }
                    cambio = 0;
                }
            }
            
            if (tamanoOriginal != LstSubgrupo.Count)
            {
                for(int i = 0; i < LstSubgrupo.Count; i++)
                {
                    LstSubgrupo[i].ID = "H" + i;
                }
            }
        }

        public List<ClasesLaterales> CrearClasesLaterales(int num){
            
            if(LstSubgrupo.Count == 0)
            {
                GenerarSubgrupos();
            }
            Subgrupo sub = LstSubgrupo[num];
            ClasesLaterales temp;
            List<ClasesLaterales> clase = new List<ClasesLaterales>();
            int total = 0;
            int i = 0;
            bool repetidos = false;

            while(total < cantSimetrias){
                temp = CrearClaseLateral(sub, Simetrias[i]);

                for(int j = 0; j < clase.Count; j++)
                {
                    if(ConjuntoRepetido(clase[j].Simetrias.ToArray(), temp.Simetrias.ToArray()))
                    {
                        repetidos = true;
                        break;
                    }
                }

                if (!repetidos)
                {
                    total += temp.Simetrias.Count;
                    clase.Add(temp);
                }

                repetidos = false;
                i++;
            }

            return clase;
        }

        private bool ConjuntoRepetido(Simetria[] c1, Simetria[] c2)
        {
            for(int i = 0; i < c1.Length; i++)
            {
                for(int j = 0; j < c2.Length; j++)
                {
                    if (c1[i].Igual(c2[j]))
                    {
                        return true;
                    }
                }
            }

            return false;
        } 

        public ClasesLaterales CrearClaseLateral(Subgrupo sub, Simetria sim){

            Simetria aux = new Simetria();

            ClasesLaterales clase = new ClasesLaterales
            {
                ID = sim.ID + " + " + sub.ID
            };

            clase.Simetrias = new List<Simetria>();

            for (int i = 0; i < sub.simetrias.Length; i++){
                aux = sub.simetrias[i].Composicion(sim);
                aux.ID = IdentificarSimetria(aux);

                clase.Simetrias.Add(aux);
            }

            return clase;
        }

        public Simetria[] OrdenarSimetrias(Simetria[] pSim){

            int k;
            Simetria temp;

            for(int i = 0; i < pSim.Length; i++){
                k = i;
                for(int j = i + 1; j < pSim.Length; j++){
                    if(pSim[j].ID.CompareTo(pSim[k].ID) < 0){
                        k = j;
                    }
                }
                temp = pSim[i];
                pSim[i] = pSim[k];
                pSim[k] = temp;
            }

            return pSim;
        } 


    }
}
