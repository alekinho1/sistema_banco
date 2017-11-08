using System;
using Dados;
using Util;
namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcao = "";
            do
            {
                Console.WriteLine("Escolha uma opção: ");
                System.Console.WriteLine("1 - Cadastrar Conta");
                System.Console.WriteLine("2 - Sacar");
                System.Console.WriteLine("3 - Depositar");
                System.Console.WriteLine("9 - Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        {
                            CadastrarConta();
                            break;
                        }

                    case "2":
                        {
                            break;
                        }

                    case "3":
                        {
                            break;
                        }
                }

            } while (opcao != "9");




        }

        static void CadastrarConta()
        {
            System.Console.WriteLine("Digite a Razão Social ");
            string razaosocial = Console.ReadLine();

            System.Console.WriteLine("Digite a Data de Abertura ");
            string dataabertura = Console.ReadLine();

            Validacao validacao = new Validacao();
            bool cnpjvalido = false;

            do
            {
                System.Console.WriteLine("Digite o CNPJ");
                string cnpj = Console.ReadLine();
                cnpjvalido = validacao.ValidarCNPJ(cnpj);

                if (cnpjvalido == true)
                {
                    System.Console.WriteLine("CNPJ Válido!");
                }
                else

                    System.Console.WriteLine("CNPJ Falso");

            } while (cnpjvalido != true);

            System.Console.WriteLine("Digite seu número de conta");
            string numeroconta = Console.ReadLine();

            System.Console.WriteLine("Digite a conta");
            string conta = Console.ReadLine();

            System.Console.WriteLine("Digite o saldo");
            double saldo = Convert.ToDouble(Console.ReadLine());

        }
    }
}
