using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FadaRapido
    {
        public string NomeRapido { get; set; }
        public string FamiliaRapido { get; set; }
        public string CorRapido { get; set; }       
        public bool MulherRapido { get; set; }
        public string ElementoRapido { get; set; }
       
      
        public FadaRapido(string nome, string familia, bool mulher)
        {
            NomeRapido = nome;
            FamiliaRapido = familia;
            MulherRapido = mulher;

        }

        public FadaRapido(string nome, string familia, string cor)
        {
            NomeRapido = nome;
            FamiliaRapido = familia;
            CorRapido = cor;
        }
    }
}
