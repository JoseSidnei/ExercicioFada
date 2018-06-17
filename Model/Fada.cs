using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fada
    {
       
        public string Nome { get; set; }
        public string Familia { get; set; }
        public string Cor { get; set; }
        public string CorAsa { get; set; }
        public string Elemento { get; set; }
        public bool Mulher { get; set; }
        public bool Fazbarulho { get; set; }

        
        public Fada(string nome, string familia, string cor)
        {
            Nome = nome;
            Familia = familia;
            Cor = cor;
        }

        public Fada(string nome, string familia, bool mulher)
        {
            Nome = nome;
            Familia = familia;
            Mulher = mulher;

        }



        

        

    }
}
