// Ana Clara Martin da Silveira - 23122
// Sofia Tasselli Kawamura - 23157

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Emprestimo
    {
        int idEmprestimo,
            idLivro,
            idLeitor;
        DateTime dataEmprestimo,
                 dataDevolucaoPrevista,
                 dataDevolucaoReal;

        public Emprestimo(int idEmprestimo, int idLivro, int idLeitor, DateTime dataEmprestimo, DateTime dataDevolucaoPrevista, DateTime dataDevolucaoReal)
        {
            this.IdEmprestimo = idEmprestimo;
            this.IdLivro = idLivro;
            this.IdLeitor = idLeitor;
            this.DataEmprestimo = dataEmprestimo;
            this.DataDevolucaoPrevista = dataDevolucaoPrevista;
            this.DataDevolucaoReal = dataDevolucaoReal;
        }

        public int IdEmprestimo 
        { 
            get => idEmprestimo; 
            set
            {
                if (value < 0)
                    throw new Exception("Id de empréstimo não pode ser negativo.");
                idEmprestimo = value;
            }
        }

        public int IdLivro 
        { 
            get => idLivro; 
            set
            {
                if (value <= 0)
                    throw new Exception("Id de livro deve ser maior que 0.");
                idLivro = value;
            }
        }

        public int IdLeitor 
        { 
            get => idLeitor; 
            set
            {
                if (value <= 0)
                    throw new Exception("Id de leitor deve ser maior que 0.");
                idLeitor = value;
            }
        }

        public DateTime DataEmprestimo 
        { 
            get => dataEmprestimo; 
            set => dataEmprestimo = value; 
        }

        public DateTime DataDevolucaoPrevista 
        { 
            get => dataDevolucaoPrevista; 
            set => dataDevolucaoPrevista = value; 
        }

        public DateTime DataDevolucaoReal 
        { 
            get => dataDevolucaoReal; 
            set => dataDevolucaoReal = value; 
        }
    }
}
