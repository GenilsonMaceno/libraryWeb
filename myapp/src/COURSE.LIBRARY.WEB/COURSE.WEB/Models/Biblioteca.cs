using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COURSE.WEB.Models
{
    public class Biblioteca
    {
        public int BibliotecaId { get; set; }
        public string Nome { get; set; }
        public string Livro { get; set; }

        public Biblioteca(int bibliotecaId, string nome, string livro)
        {
            BibliotecaId = bibliotecaId;
            Nome = nome;
            Livro = livro;
        }


        public Biblioteca()
        {
        }
    }
}