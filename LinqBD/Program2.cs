using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBD
{
    class Program2
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            //lista de filmes de drama
            /*var lista = from filme in dc.filmes
                        where filme.categoria == "FD"
                        select filme;*/

            //filmes começados por "O"
            /*var lista = from filme in dc.filmes
                        where filme.titulo.StartsWith("O")
                        select filme;*/

            //filmes com determinado conjunto de carateres no titulo
            var lista = from filme in dc.filmes
                        where filme.titulo.Contains("ext")
                        select filme;

            foreach (var filme in lista)
            {
                Console.WriteLine($"ID: {filme.id}");
                Console.WriteLine($"Título: {filme.titulo}");
                Console.WriteLine($"Categoria: {filme.categoria}");
                Console.WriteLine();
            }

            Console.WriteLine($"Existem {lista.Count()} filmes");

            Console.WriteLine("\n--------Contar por categoria--------\n");

            var NovaLista = from filme in dc.filmes
                            group filme by filme.categoria
                            into c
                            select new
                            {
                                categoria = c.Key,
                                contagem = c.Count()
                            };

            foreach (var c in NovaLista)
            {
                Console.WriteLine($"{c.categoria} ({c.contagem})");
            }

            Console.WriteLine("\n--------Junção entre tabelas--------\n");

            var OutraLista = from filme in dc.filmes
                             join categoria in dc.categorias
                             on filme.categoria equals categoria.sigla
                             select new
                             {
                                 filme.id, filme.titulo, categoria.categoria1
                             };

            foreach (var o in OutraLista)
            {
                Console.WriteLine($"ID: {o.id}");
                Console.WriteLine($"Título: {o.titulo}");
                Console.WriteLine($"Categoria: {o.categoria1}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
