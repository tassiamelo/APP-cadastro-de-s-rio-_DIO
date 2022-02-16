using System;

namespace DIO.Series
{

    class Program

    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSeries();
                        break;
                    case "4":
                        ExcluirSeries();
                        break;
                    case "5":
                        VisualizarSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }


        }

        private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Dio Series a seu dispor!!!");
            System.Console.WriteLine("Informe a opção desejada: ");
            System.Console.WriteLine("1- Listar séries");
            System.Console.WriteLine("2- Inserir nova série");
            System.Console.WriteLine("3- Atualizar série");
            System.Console.WriteLine("4- Excluir série");
            System.Console.WriteLine("5- Visualizar série");
            System.Console.WriteLine("C- Limpar Tela");
            System.Console.WriteLine("X- Sair");
            System.Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return opcaoUsuario;
        }
      

        private static void VisualizarSeries()
        {
             System.Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie());

            System.Console.WriteLine(serie);
        }

        private static void ExcluirSeries()
        {
            System.Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);
        }

        private static void AtualizarSeries()
        {
            System.Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0}-{1}" , i, Enum.GetName(typeof(Genero), i));
            }
            System.Console.WriteLine("Digite  o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite  o título da série: ");
            string entradaTítulo = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite  a descrição da série: ");
            string entradaDescricao = int.Parse(Console.ReadLine());

            Series novaSerie = new DIO.Series[id]: indiceSerie,
                                genero: (Genero)entradaGenero,
                                titulo: entradaTítulo,
                                ano: entradaAno,
                                descrição: entradaDescricao;
                                    
            repositorio.Atualiza(indiceSerie, AtualizarSeries);

        }

        private static void InserirSeries()
        {
            System.Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0}-{1}" , i, Enum.GetName(typeof(Genero), i));
            }
            System.Console.WriteLine("Digite  o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite  o título da série: ");
            string entradaTítulo = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite  a descrição da série: ");
            string entradaDescricao = int.Parse(Console.ReadLine());

            Series novaSerie = new DIO.Series[id]: repositorio.ProximoId(),
                                                genero: (Genero)entradaGenero,
                                titulo: entradaTítulo,
                                ano: entradaAno,
                                descrição: entradaDescricao;

                                    
            repositorio.Insere(novaSerie);


        }

        private static void ListarSeries()
        {
            System.Console.WriteLine("Listar séries");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                System.Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();

                System.Console.WriteLine("DIO {0}: - {1} - {2}" , serie.retornaId() , serie.retornaTitulo(), (excluido ? "Excluido" : "" ));
            }
        }
    }
    }
