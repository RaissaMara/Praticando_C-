namespace Praticando_C__Alura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

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

        }
    }
}
