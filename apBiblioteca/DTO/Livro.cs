// Ana Clara Martin da Silveira - 23122
// Sofia Tasselli Kawamura - 23157

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Livro
    {
        const int tamanhoCodigo = 6;
        const int tamanhoTitulo = 50;
        const int tamanhoAutor = 50;

        int idLivro;
        string codigoLivro;
        string tituloLivro;
        string autorLivro;

        public Livro(int id, string codigo, string titulo, string autor)
        {
            IdLivro = id;
            CodigoLivro = codigo;
            TituloLivro = titulo;
            AutorLivro = autor;
        }

        public int IdLivro
        {
            get => idLivro;
            set
            {
                if (value < 0)
                    throw new Exception("Id negativo para livro é inválido!");
                idLivro = value; // armazena o valor passado no atributo de destino
            }
        }

        public string CodigoLivro
        {
            get => codigoLivro;
            set
            {
                codigoLivro = value.PadLeft(tamanhoCodigo, '0').Substring(0, tamanhoCodigo);
            }
        }

        public string TituloLivro
        {
            get => tituloLivro;
            set
            {
                tituloLivro = value.PadRight(tamanhoTitulo, ' ').Substring(0, tamanhoTitulo);
            }
        }

        public string AutorLivro
        {
            get => autorLivro;
            set
            {
                autorLivro = value.PadRight(tamanhoAutor, ' ').Substring(0, tamanhoAutor);
            }
        }

    }
}
