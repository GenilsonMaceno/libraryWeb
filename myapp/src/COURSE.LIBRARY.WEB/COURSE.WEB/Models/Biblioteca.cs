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

        public List<Biblioteca> CriarDados()
        {
            var bibliotecas = new List<Biblioteca>()
            {
                new Biblioteca
                {
                    BibliotecaId = 1,
                    Livro = "Teste",
                    Nome = "São Judas"
                },

                new Biblioteca
                {
                    BibliotecaId = 2,
                    Livro = "Teste 2",
                    Nome = "São Judas"
                },

                new Biblioteca
                {
                    BibliotecaId = 3,
                    Livro = "Teste 3",
                    Nome = "São Judas"
                }
            };

            return bibliotecas;
        }
    }
}