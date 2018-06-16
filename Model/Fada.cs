using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fada
    {
       private string nome;
       private string familia;
       private string corAsa;
       private double tamanhoAsa;
       public bool mulher;
       private string elemento;

        /*Construtores
         nome, familia, cor
         nome, cor, mulher*/

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome deve ser preenchido");
                }

                if (value.Count() == 1)
                {
                    throw new Exception("Nome deve conter no mínimo 2 caracteres");
                }

                nome = value;
            }
        }

        public string Familia
        {
            get
            {
                return familia;
            }
            set
            {
                familia = value;
            }
        }

        public string Cor { get; set; }

        public string CorAsa
        {
            get
            {
                return corAsa;
            }
            set
            {
                corAsa = value;
            }
        }

        public bool Mulher
        {
            get
            {
                return mulher;
            }
            set
            {
                mulher = value;
            }
        }

       

    }
}
