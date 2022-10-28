using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad.clases
{
    public class Dado
    {
        List<int> caras;

        public Dado()
        {
            Caras = CargarDado();
        }

        public List<int> Caras { get => caras; set => caras = value; }

        private List<int> CargarDado()
        {
            List<int> dados = new List<int>();
            dados.Add(1);
            dados.Add(2);
            dados.Add(3);
            dados.Add(4);
            dados.Add(5);
            dados.Add(6);
            return dados;
        }
    }
}
