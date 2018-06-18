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
        private string cor;  
        private string corAsa; 
        private string elemento;
        private bool asaQuebrada;
        private bool mulher;
        private bool fazbarulho;
        private double tamanhoAsa;

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

                if (value.Count() < 2)
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Familia deve ser preenchido");
                }

                if (value.Count() < 4)
                {
                    throw new Exception("Familia deve cnter no mínimo 4 caracteres");
                }

                if (value.Count() > 30)
                {
                    throw new Exception("Familia deve ter no máximo 30 caracteres");
                }

                familia = value;
            }
        }

        public string Cor
        {
            get
            {
                return cor;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Selecione uma cor");
                }

                cor = value;
            }
        }

        public string CorAsa
        {
            get
            {
                return corAsa;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Selecona uma Cor para Asa");
                }

                corAsa = value;
            }
        }

        public string Elemento
        {
            get
            {
                return elemento;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Selecione um elemento");
                }

                elemento = value;
            }
        }

        public double TamanhoAsa
        {
            get
            {
                return tamanhoAsa;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Tamanho da Asa deve ser maior que zero");
                }

                if (value > 15)
                {
                    throw new Exception("Tamanho da Asa deve ser no máximo 15");
                }

                tamanhoAsa = value;
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

        public bool AsaQuebrada
        {
            get
            {
                return asaQuebrada;
            }
            set
            {                
                asaQuebrada = value;
            }
        }

        public bool FazBarulho
        {
            get
            {
                return fazbarulho;
            }
            set
            {
                fazbarulho = value;
            }
        }
    }
}
