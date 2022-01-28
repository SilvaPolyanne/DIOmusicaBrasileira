using System;
using System.Collections.Generic;
using DIO.Musica.Interfaces;

namespace DIOmusicaBrasileira
{
    class Program
    {
        static MusicaRepositorio repositorio = new MusicaRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarMusica();
                        break;
                    case "2":
                        InserirMusica();
                        break;
                    case "3":
                        AtualizarMusica();
                        break;
                    case "4":
                        ExcluirMusica();
                        break;
                    case "5":
                        VisualizarMusica();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.WriteLine();
        }

        private static void ListarMusica()
        {
            Console.WriteLine("Listar músicas");
            var lista = repositorio.Lista();

            if (lista.Count == O)
            {
                Console.WriteLine("Nenhuma música cadastrada");
                return;
            }

            foreach (var musica in lista)
            {
                var excluido = musica.retornaExcluido();
                Console.WriteLine("#ID {0}: - {1} - {2}", musica.retornaId(), musica.retornaNomeMusica(), (excluido ? "*Excluído*" : ""));
            }
        }

        private static void InserirMusica()
        {
            Console.WriteLine("Inserir nova música");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.Readline());

            Console.WriteLine("Digite o nome do intérprete: ");
            string entradaNomeInterprete = Console.Readline();

            Console.WriteLine("Digite o nome da música: ");
            string entradaNomeMusica = Console.Readline();

            Console.WriteLine("Digite o ano de lançamento da música: ");
            int entradaAno = int.Parse(console.Readline());

            Console.WriteLine("Digite a letra da música: ");
            string entradaLetraMusica = Console.Readline();

            Musica novaMusica = new Musica(id: repositorio.ProximoId(),
                                            nomeinterprete: entradaNomeInterprete,
                                            nomemusica: entradaNomeMusica,
                                            ano: entradaAno,
                                            genero: (Genero)entradaGenero,
                                            letramusica: entradaLetraMusica);
            repositorio.Insere(novaMusica);
        }

        private static void AtualizarMusica()
        {
            Console.WriteLine("Digite o ID da música: ");;
            int indiceMusica = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeog(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(GenericUriParserOptions), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o nome do intérprete: ");
            string entradaNomeInterprete = Console.ReadLine();

            Console.Write("Digite o nome da música: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de publicação da música: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a letra da música: ");
            string entradaLetraMusica = Console.ReadLine();

            Musica atualizaMusica = new Musica(id: indiceMusica,
                                            nomeinterprete: entradaNomeInterprete,
                                            nomemusica: entradaNomeMusica,
                                            ano: entradaAno,
                                            genero: (Genero)entradaGenero,
                                            letramusica: entradaLetraMusica);
            repositorio.Atualiza(indiceMusica, atualizaMusica);
        }

        private static void ExcluirMusica()
        {
            Console.Write("Digite o ID da música: ");
            int indiceMusica = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceMusica);
        }

        private static void VisualizarMusica()
        {
            Console.Write("Digite o ID da música: ");
            int indiceMusica = int.Parse(Console.ReadLine());

            var musica = repositorio.RetornaPorId(indiceMusica);

            Console.WriteLine(musica);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Música Brasileira ao seu dispor!");
            Console.WriteLine("Informe a opção desejada: ");
            
            Console.WriteLine("1- Listar músicas");
            Console.WriteLine("2- Inserir uma nova música");
            Console.WriteLine("3- Atualizar uma música");
            Console.WriteLine("4- Excluir uma música");
            Console.WriteLine("5- Visualizar uma música");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.Readline().ToUpper();
            Console.Writeline;
            return opcaoUsuario;
        }
    }
}