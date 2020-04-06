using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBD
{
    class Program
    {
        static void Main2(string[] args)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            //Obter listagem de filmes
            //var lista = from filme in dc.filmes orderby filme.titulo select filme;

            //
            var lista = from filme in dc.filmes
                        orderby filme.titulo descending, filme.id
                        select filme;

            foreach (var filme in lista)
            {
                Console.WriteLine($"ID: {filme.id}");
                Console.WriteLine($"Título: {filme.titulo}");
                Console.WriteLine($"Categoria: {filme.categoria}");
                Console.WriteLine();
            }

            Console.WriteLine($"Existem {lista.Count()} filmes");

            Console.ReadKey();
        }
    }
}
