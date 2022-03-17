using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNombre
{
    public class Grupo
    {
        public event EventHandler NombreAgregado;
        private List<string> alumnos;
        public List<string> Alumnos
        {
            get { return alumnos; }
        }

        public void Agregar(string nombre)
        {
            if (alumnos == null)
            {
                alumnos = new List<string>();
                alumnos.Add(nombre);
            }
            else
            {
                bool insertado = false;
                for (int i = 0; i < alumnos.Count; i++)
                {
                    if (String.Compare(nombre, alumnos[i]) == -1)
                    {
                        alumnos.Insert(i, nombre);
                        insertado = true;
                        break;
                    }
                }
                if (!insertado)
                {
                    alumnos.Add(nombre);
                }
                
            }
            NombreAgregado!.Invoke(this, null);
        }

        public bool Existe(string nombre)
        {
            foreach (var alumno in alumnos)
            {
                if (String.Compare(alumno,nombre)==0)
                {

                    return true;
                }
            }
            return false;
        }

        public int ContarEmpieza(string filtro)
        {
            int cuantos = 0;
            foreach (var alumno in alumnos)
            {
                if (alumno.StartsWith(filtro))
                {
                    cuantos++;
                }
            }
            return cuantos;
        }
    }
}

