using System.Security.AccessControl;
using System.Threading.Channels;

namespace Praticando_C__Alura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello, World!");

             //Praticando_C#: Variáveis e Tipos

             //Exemplo alura (Ano 1997)
             int anoNascimento = 2002;
             int anoVigente = 2026;

             int idade = anoVigente - anoNascimento;
             Console.WriteLine("Idade: " + idade);

             //Exemplo alura
             float valorRecebido = 500.00f;
             bool doacaoAnonima = true;
             char tipoConta = 'P';

             Console.WriteLine("Valor recibido: R$" + valorRecebido);
             Console.WriteLine("Doação Anônima: " + doacaoAnonima);
             Console.WriteLine("Tipo de Conta:" + tipoConta);

             //Meu exemplo de treino
             double milha = 1.60934;
             Console.Write("Digite a quantidade de milhas desejadas e converteremos para quilometragem:");
             double quantidade = double.Parse(Console.ReadLine()!);
             double equivalem = quantidade * milha;
             Console.WriteLine($"{quantidade} milhas equivalem a {equivalem} quilomêtros");

             //Exemplo alura
             double milhas = 10.0;
             double quilometros = milhas * 1.60934;
             Console.WriteLine(milhas + " milhas equivalem a " + quilometros + " quilomêtros.");

             int totalMinutos = 250;
             int horas = totalMinutos / 60;
             int minutosRestante = totalMinutos % 60;
             Console.Write($"Tempo: {horas} horas e {minutosRestante} minutos");

             //Exemplo alura
             int minutos = 250;
             int hora = minutos / 60;
             int restantesMinutos = minutos % 60;

             Console.WriteLine("Tempo: " + hora + " horas e " + restantesMinutos + " minutos");

             double largura = 10.5;
             double comprimento = 20.3;

             double area = largura * comprimento;
             Console.WriteLine($"A área do terreno é: {area} metros quadrados");

             //Meu exemplo
             Console.Write("Digite a nota do aluno 1:");
             float aluno1 = float.Parse(Console.ReadLine()!);
             Console.Write("Digite a nota do aluno 2:");
             float aluno2 = float.Parse(Console.ReadLine()!);
             Console.Write("Digite a nota do aluno 3:");
             float aluno3 = float.Parse(Console.ReadLine()!);

             float soma = aluno1 + aluno2 + aluno3;
             float media = soma / 3;
             Console.WriteLine($"A média das notas é: {media}");

             //Exemplo da Alura
             float nota1 = 7.2f;
             float nota2 = 8.3f;
             float nota3 = 9.1f;

             float medias = (nota1 + nota2 + nota3) / 3;

             Console.WriteLine("A média das notas é: " + medias);

             //Exemplo de Conversão
             decimal pesoContainers = 18.75m;
             int quantMinima = Convert.ToInt32(pesoContainers);

             Console.WriteLine("Quantidade Mínínima de veículos: " + quantMinima);

             //Exemplo no alura
             decimal pesoContainer = 18.75m;
             int veiculosNecessarios = (int)pesoContainer;

             Console.WriteLine("Veículos necessários: " + veiculosNecessarios);

             //Criado por mim
             int vidasIniciais = 5;
             Console.WriteLine($"Você têm {vidasIniciais} vidas");
             for (int i = 1; i <= 5; i++)
             {
                 Console.WriteLine($"Você usou {i} vida");
             }
             vidasIniciais++;

             Console.WriteLine("Você conseguiu finalizar com: " + vidasIniciais);

             //Exemplo do Alura
             int vidas = 5;
             vidas--;
             vidas++;
             vidas++;
             int vidasFinais = vidas;

             Console.WriteLine("Vidas finais: " + vidasFinais);

             //Para calcular o valor 
             Console.WriteLine("Digite o salário Atual:");
             decimal salarioAtual = decimal.Parse(Console.ReadLine()!);
             Console.WriteLine("Digite o Percentual Aumentado:");
             decimal percentualAumentado = decimal.Parse(Console.ReadLine()!);

             decimal novoSalario = salarioAtual + (salarioAtual * percentualAumentado / 100);

             Console.WriteLine("O novo salário é de R$" + novoSalario + ",00");

             //Exemplo Alura
             decimal salariAtual = 1500.0m;
             decimal percentualAumento = 10.0m;
             decimal novSalario = salariAtual + (salariAtual * percentualAumento / 100);

             Console.WriteLine("O novo salário é de R$" + novSalario.ToString("F2"));

             //Calculando a área e o perímetro
             double pii = 3.14159;
             double raioo = 5.0;
             double areaa = pii * raioo * raioo;
             double perimetroC = 2 * pii * raioo;

             Console.WriteLine($"Raio:{raioo}");
             Console.WriteLine($"Área do Círculo:{areaa}");
             Console.WriteLine($"Perímetro do Círculo:{perimetroC}");

             //Exemplo alura
             double raio = 5.0;
             double pi = 3.14159;

             double area2 = pi * raio * raio;
             double perimetro = 2 * pi * raio;

             Console.WriteLine("Raio: " + raio.ToString("F2"));
             Console.WriteLine("Área do círculo: " + area2.ToString("F2"));
             Console.WriteLine("Perímetro do círculo: " + perimetro.ToString("F2"));

            //Praticando_C#: Laços e Repetição

            int contador = 10;
            while (contador >= 1)
            {
                Console.WriteLine(contador);
                contador--;
            }

            Console.WriteLine("Você chegou ao fim!");

            int opcao;
            do
            {
                Console.WriteLine("\nMENU:");
                Console.WriteLine("1 - Ver produtos");
                Console.WriteLine("2 - Fazer pedidos");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Mostrando produtos...");
                        break;
                    case 2:
                        Console.WriteLine("Fazer pedido");
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Escolha um número");
                        break;
                }

                Console.Clear();
            } while (opcao != 0);


            // Exercícios
            //Soma das vendas

            // Tentativa pessoal
           double totalVendas = 0;
            int opcao;
            
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Exibir Catálogo ");
                Console.WriteLine("2 - Selecionar Produto ");
                Console.WriteLine("4 - Total a pagar: ");
                Console.WriteLine("0 - Para encerrar. ");
                Console.WriteLine("Selecione um produto: ");

                opcao = int.Parse(Console.ReadLine()!);


                switch (opcao)
                {

                    case 1:
                        Console.WriteLine("Exibindo produtos...");
                        break;
                    case 2:
                        Console.Write("Digite a quantidade:");
                        int quantProd = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor unitário:");
                        double valorProduto = double.Parse(Console.ReadLine());

                        totalVendas += (quantProd * valorProduto);
                        Console.WriteLine("Item adicionado ao caixa!");
                        break;
                    case 4:
                        Console.WriteLine($" Total de compras: R$ {totalVendas:F2}");
                        break;
                    case 0:
                        Console.WriteLine("Caixa encerrado... ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.Clear();
            } while (opcao != 0);


            //Como o exercício pede:
            int valor, total = 0;

            do
            {
                Console.Write("Digite o valor da venda (ou 0 para encerrar): ");
                valor = int.Parse(Console.ReadLine());

                total += valor;
            } while (valor != 0);

            Console.WriteLine("Total de vendas do dia: R$" + total);*/

            //Minha tentativa

            int valor;
            int total = 0;

            do
            {

                Console.WriteLine("Digite o valor da venda (ou 0 para encerrar): ");
                valor = int.Parse(Console.ReadLine()!);

                total += valor;

            } while (valor != 0); 
                Console.WriteLine($"Total de vendas do dia: R$ {total:F2}");

               int escolha;
            int estoqueAtual, quantidade = 0;
            do 
            { 
            
                Console.WriteLine("Deseja adicionar um produto ao estoque? \n1 - Sim | 0 - Não ");
                Console.WriteLine("Escolha 1 ou 0 para adicionar um produto.");
                escolha = int.Parse(Console.ReadLine());


                switch (escolha)
                {

                    case 1: Console.WriteLine("Quantidade:");
                            quantidade = int.Parse(Console.ReadLine());
                            Console.WriteLine("Estoque atual:");
                            estoqueAtual = int.Parse(Console.ReadLine());
                            Console.WriteLine("Deseja continuar? \n1 - Sim | 0 - Não ");
                        break;

                    case 0: Console.WriteLine("Nenhum produto adicionado...");
                            break;

                    default: Console.WriteLine("Escolha ");
                            break;
                }
                estoqueAtual += quantidade;

            }while (escolha != 0);
                     Console.WriteLine("Obrigado por usar nosso sistema de estoque!");

        }

    }
}
