using System.Drawing;

namespace Lista02.ConsoleApp
{
    internal class Program
    {
        //-5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6                           
        static void Main(string[] args)
        {
            int[] sequencia = new int[16];
            //atribuindo os valores nas gavetas do array
            sequencia[0] = -5;
            sequencia[1] = 3;
            sequencia[2] = 4;
            sequencia[3] = 5;
            sequencia[4] = 9;
            sequencia[5] = 6;
            sequencia[6] = 10;
            sequencia[7] = -2;
            sequencia[8] = 11;
            sequencia[9] = 1;
            sequencia[10] = 2;
            sequencia[11] = 6;
            sequencia[12] = 7;
            sequencia[13] = 8;
            sequencia[14] = 0;
            sequencia[15] = -6;
            //Mostrar na Tela os valores da sequência
            //forma manual a baixo
            //for (int i = 0; i < sequencia.Length; i++)
            //{
            //    Console.Write(sequencia[i] + ", ");
            //}
            Console.WriteLine($"Sequencia: [{string.Join(", ", sequencia)}]");

            //Encontrar o Maior Valor da sequência
            int maiorValor = int.MinValue;
            for ( int i = 0; i < sequencia.Length; i++ ) 
            {
                int valorAtual = sequencia[i];
                if (valorAtual > maiorValor) 
                {
                    maiorValor = sequencia[i];
                }

            }
            Console.WriteLine("Maior Valor : " + maiorValor);

            //Encontrar o Menor Valor da sequência
            int menorValor = int.MaxValue;
            for ( int i = 0;i < sequencia.Length;i++ ) 
            {
                int valorAtual = sequencia[i];
                if (valorAtual < menorValor)
                {
                    menorValor = sequencia[i];
                }
            }
            Console.WriteLine("Menor Valor : " + menorValor);

            //Encontrar o Valor Médio da sequência primeiro tem que ser somado!
            decimal soma = 0;
            for (int i = 0; i < sequencia.Length; i++)
            {
                int valorAtual = sequencia[i];
                soma += valorAtual;
            }
            //fazendo o calculo para trazer a média
            decimal media = soma / sequencia.Length;
            Console.WriteLine("Valor médio é de: " + media);

            //Encontrar os 3 maiores valores da sequência
            int[] copia = new int[sequencia.Length];
            Array.Copy(sequencia, copia, sequencia.Length);
            Array.Sort(copia);
            Array.Reverse(copia);
            Console.WriteLine($"Os 3 maiores valores são: {copia[0]}, {copia[1]}, {copia[2]}");

            //Encontrar os valores negativos da sequência
            int contValoresNegativos = 0;
            for(int i = 0; i < sequencia.Length; i++)
            {
                int valorAtual = sequencia[i];
                if (valorAtual < 0);
                contValoresNegativos++;
            }
            int[] valoresNegativos = new int[contValoresNegativos];
            int indiceNegativos = 0;
            for (int i = 0; i < sequencia.Length; i++)
            {
                int valorAtual = sequencia[i];
                if (valorAtual < 0)
                {
                    valoresNegativos[indiceNegativos] = valorAtual;
                    indiceNegativos++;
                }
            }
            Console.WriteLine($"Valores negativos: [{string.Join(", ", valoresNegativos)}");

            //Remover um item da sequência
            int posicaoRemover = Array.IndexOf(sequencia, 11);
            int[] novoArray = new int[sequencia.Length - 1];
            int contador = 0;

            for (int i = 0; i < sequencia.Length; i++)
            {
                if(i != posicaoRemover)
                {
                    novoArray[contador] = sequencia[i];
                    contador++;
                }
            }
            Console.WriteLine($"Sequência com a remoção: [{string.Join(",", novoArray)}]");

            Console.ReadLine();
        }
    }
}
