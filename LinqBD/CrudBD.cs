using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBD
{
    class CrudBD
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            //Inserir novo registo
            filme f = new filme
            {
                id = dc.filmes.Count() + 100,
                titulo = "O exterminador 3",
                categoria = "FC"
            };

            dc.filmes.InsertOnSubmit(f);

            try
            {
                dc.SubmitChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var lista = from filme in dc.filmes select filme;

            foreach (var filme in lista)
            {
                Console.WriteLine($"ID: {filme.id}");
                Console.WriteLine($"Título: {filme.titulo}");
                Console.WriteLine($"Categoria: {filme.categoria}");
                Console.WriteLine();
            }

            Console.WriteLine($"Existem {lista.Count()} filmes");

            Console.WriteLine("\n--------Alterar registo--------\n");
            //Alterar registo

            int IDAlterar = 4;
            var pesquisa = from filme in dc.filmes
                           where filme.id == IDAlterar
                           select filme;

            f = pesquisa.Single();

            f.titulo = "O título foi alterado";

            try
            {
                dc.SubmitChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var lista2 = from filme in dc.filmes select filme;

            foreach (var filme in lista2)
            {
                Console.WriteLine($"ID: {filme.id}");
                Console.WriteLine($"Título: {filme.titulo}");
                Console.WriteLine($"Categoria: {filme.categoria}");
                Console.WriteLine();
            }

            Console.WriteLine($"Existem {lista.Count()} filmes");

            Console.WriteLine("\n--------Apagar registo--------\n");
            //Apagar registo
            
            filme filmeApagar = new filme();

            var outraPesquisa = from filme in dc.filmes
                                where filme.id == 5
                                select filme;

            if(outraPesquisa.Count() == 0)
            {
                Console.WriteLine("O filme já foi apagado");
                Console.ReadKey();
                return;
            }

            filmeApagar = outraPesquisa.Single();

            dc.filmes.DeleteOnSubmit(filmeApagar);

            try
            {
                dc.SubmitChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var listaApagada = from filme in dc.filmes
                               select filme;

            foreach (var filme in listaApagada)
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
