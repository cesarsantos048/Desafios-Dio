using System;
using AppSerie.Classes;
using AppSerie.Enum;

namespace AppSerie
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
                string opcaoUsuario = ObterOpcaoUsuario();

                while(opcaoUsuario.ToUpper() != "X")
                {
                    switch(opcaoUsuario)
                    {
                        case "1":
                            ListarSeries();
                            break;
                        case "2":
                            InserirSerie();
                            break;
                        case "3":
                            AtualizaSerie();
                            break;
                        case "4":
                            ExcuirSerie();
                            break;
                        case "5":
                            VisualizaSerie();
                            break;
                        case "C":
                            Console.Clear();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    opcaoUsuario = ObterOpcaoUsuario();
                }
                
                    Console.WriteLine("Obrigado por utilizar nossos serviços");

                    Console.ReadLine();
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Lista de series");

            var lista = repositorio.Lista();
            if(lista.Count == 0 )
            {
                Console.WriteLine("Nenhuma serie cadastrada");
                return;
            }
            foreach(var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                
                Console.WriteLine("#Id {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? " ** Excluido": ""));
            }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova series");

            foreach(int i in Genero.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Genero.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());


            Console.Write("Digite o titulo da serie: ");
            string entradaTitulo = Console.ReadLine();
            
            Console.Write("Digite o ano da serie: ");
            int entradaAno = int.Parse(Console.ReadLine());
            
            Console.Write("Digite a descricao da serie: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno);
            repositorio.Insere(novaSerie);

        }

        private static void AtualizaSerie(){
            Console.WriteLine("Digite o id da serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());


            foreach(int i in Genero.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Genero.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o titulo da serie: ");
            string entradaTitulo = Console.ReadLine();
            
            Console.Write("Digite o ano da serie: ");
            int entradaAno = int.Parse(Console.ReadLine());
            
            Console.Write("Digite a descricao da serie: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno);
            repositorio.Atualizar(indiceSerie, atualizaSerie);
        }

        private static void ExcuirSerie()
        {
           Console.WriteLine("Digite o id da serie: ");
           int indiceSerie = int.Parse(Console.ReadLine()); 

           repositorio.Excluir(indiceSerie);
        }

        private static void VisualizaSerie()
        {
            Console.WriteLine("Digite o id da serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }


        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar series");
            Console.WriteLine("2 - Inserir nova serie");
            Console.WriteLine("3 - Atualizar serie");
            Console.WriteLine("4 - Excluir  serie");
            Console.WriteLine("5 - Visualizar  serie");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}