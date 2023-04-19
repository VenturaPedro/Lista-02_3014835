using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Lista2{
    class Lista2{

        static void Exercicio_1(){

            const int valorMinimo = 23;
            const int numValores = 172;
            const int valorMaximo = 9568;

            int[] valores = new int[numValores];
            Random random = new Random();
            for (int i = 0; i < numValores; i++){
                valores[i] = random.Next(valorMinimo, valorMaximo);
                Console.WriteLine(valores[i]);
            }

            // Encontrar o maior e o menor valor
            int maiorValor = valores[0];
            int menorValor = valores[0];
            for (int i = 1; i < numValores; i++){
                if (valores[i] > maiorValor){
                    maiorValor = valores[i];
                }
                if (valores[i] < menorValor){
                    menorValor = valores[i];
                }
            }
            Console.WriteLine("Maior valor: " + maiorValor);
            Console.WriteLine("Menor valor: " + menorValor);

            double somaValoresParesMenores100 = 0;
            int numValoresParesMenores100 = 0;
            for (int i = 0; i < numValores; i++){
                if (valores[i] < 100 && valores[i] % 2 == 0){
                    somaValoresParesMenores100 += valores[i];
                    numValoresParesMenores100++;
                }
            }
            double mediaValoresParesMenores100 = 1;
            mediaValoresParesMenores100 = somaValoresParesMenores100 / numValoresParesMenores100;
            if (mediaValoresParesMenores100 > 0){
                Console.WriteLine("Média aritmética dos valores pares e menores que 100: {0}", mediaValoresParesMenores100);
            }
            else{
                Console.WriteLine("Média aritmética dos valores pares e menores que 100: INEXISTENTE");
            }
            int maiorValorEntre100 = 0;
            int menorValorEntre100 = 100;

            for (int i = 0; i < numValores; i++){
                if (valores[i] <= 100 && valores[i] % 2 == 0){
                    if (valores[i] > maiorValorEntre100){
                        maiorValorEntre100 = valores[i];
                    }
                    if (valores[i] < menorValorEntre100){
                        menorValorEntre100 = valores[i];
                    }
                }
            }
            if (maiorValorEntre100 == 0){
                Console.WriteLine("O Maior Valor entre 23 a 100 é INEXISTENTE");
            }
            else{
                Console.WriteLine("O Maior valor entre 23 a 100 é {0}", maiorValorEntre100);
            }
            if (menorValorEntre100 == 100){
                Console.WriteLine("O Menor Valor entre 23 a 100 é INEXISTENTE");
            }
            else{
                Console.WriteLine("Menor valor entre 100 é {0}", menorValorEntre100);
            }
            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();
        }
        public static void Exercicio_2(){

            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey(); int ValorAtual = 0;
            int valorTroca;
            int Media = 0, Cont = 0;

            do{
                Console.WriteLine("Entre com valores positivos");
                Console.WriteLine("Valores negativos encerram o programa");
                valorTroca = int.Parse(Console.ReadLine());

                if (valorTroca >= 0){
                    ValorAtual = valorTroca;
                    Media = Media + valorTroca;
                    Cont++;
                }
                else{
                    Media = Media / (Cont);
                    Console.WriteLine("A média aritimética dos valores inseridos é:{0}", Media);
                    Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
                    Console.ReadKey();
                    return;
                }
            }
            while (ValorAtual > 0);
        }
        public static void Exercicio_3(){
            int numValores = 0;
            int XvalorMinimo = 0;
            int YvalorMaximo = 0;

            Console.WriteLine("Por favor entre com a variavél X (inicio da contagem):");
            XvalorMinimo = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor entre com a variavél Y (fim da contagem):");
            YvalorMaximo = int.Parse(Console.ReadLine());

            numValores = (YvalorMaximo - XvalorMinimo) + 1;
            float[] numeros = new float[numValores];
            float[] Numero3ou5 = new float[YvalorMaximo];
            float[] NumerosResto = new float[YvalorMaximo];

            for (int i = 0; i < numValores; i++){
                numeros[i] = i + XvalorMinimo;
            }

            for (int i = 0; numeros[i] < YvalorMaximo; i++){
                NumerosResto[i] = numeros[i] % 7;
            }

            for (int i = 0; numeros[i] < YvalorMaximo; i++){
                if (NumerosResto[i] == 3 || NumerosResto[i] == 5){
                    Numero3ou5[i] = numeros[i];
                }
            }

            Console.WriteLine("Os numeros que possuem resto igual a 3 ou 5 são:");
            for (int i = 0; numeros[i] < YvalorMaximo; i++){
                if (Numero3ou5[i] != 0){
                    Console.WriteLine(Numero3ou5[i]);
                }
            }
            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();
        }
        static void Exercicio_4(){
            //Faça um programa que leia um número Ppositivo e mostre na tela os 3 primeiros
            //números pares que são ao mesmo tempo divisíveis por 4, mas não por 6.

            Console.WriteLine("Digite um número positivo: ");
            int p = int.Parse(Console.ReadLine());

            int contador = 0;
            int numero = 0;

            while (contador < p * 3){
                numero += 2;
                if (numero % 4 == 0 && numero % 6 != 0){
                    Console.WriteLine("Os números pares que são ao mesmo tempo divisíveis por 4, mas não por 6 :{0}\n ", numero);
                    contador++;
                }
            }
        }
        static void Exercicio_5(){
            Console.WriteLine("Digite o número de linhas: ");
            int numLinhas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o caractere para a figura: ");
            char caractere = char.Parse(Console.ReadLine());
            Console.WriteLine();

            // loop para criar as linhas da figura
            for (int i = 1; i <= numLinhas; i++){
                // loop para criar os caracteres de cada linha
                for (int j = 1; j <= i; j++){
                    Console.Write(caractere);
                }
                Console.WriteLine(); // pula para a próxima linha
            }

            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();
        }
        static void Exercicio_6(){

            Console.Write("Digite o número de linhas: ");
            int numLinhas = int.Parse(Console.ReadLine());

            Console.Write("Digite o caractere: ");
            char caractere = char.Parse(Console.ReadLine());

            for (int i = 1; i <= numLinhas; i++){
                for (int j = 1; j <= numLinhas - i; j++){
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++){
                    Console.Write(caractere);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tecle [Enter] para exibir o próximo passo");
            Console.ReadKey();
        }

        static int Main(string[] args){
            int ValorExercicios;

            do{
                Console.WriteLine("----ENTRE COM O VALOR DO EXERCICIO------ ");
                Console.WriteLine("---------------------------------------- ");
                Console.WriteLine("PARA SAIR----------------------------- 0 ");
                Console.WriteLine("---------------------------------------- ");
                Console.WriteLine("172 valores--------------------------- 1 ");
                Console.WriteLine("Média conjunto de valores------------- 2 ");
                Console.WriteLine("Resto 3 ou 5 ------------------------- 3 ");
                Console.WriteLine("Numero positivo----------------------- 4 ");
                Console.WriteLine("Meia piramide ------------------------ 5 ");
                Console.WriteLine("Piramide completa--------------------- 6 ");
                Console.WriteLine("----------------------------------------\n ");

                ValorExercicios = int.Parse(Console.ReadLine());

                switch (ValorExercicios){
                    case 0:
                        Console.WriteLine("Até a próxima");
                        Console.ReadKey();
                        break;
                    case 1:
                        Exercicio_1();
                        break;
                    case 2:
                        Exercicio_2();
                        break;
                    case 3:
                        Exercicio_3();
                        break;
                    case 4:
                        Exercicio_4();
                        break;
                    case 5:
                        Exercicio_5();
                        break;
                    case 6:
                        Exercicio_6();
                        break;
                    default:
                        Console.WriteLine("O numero não corresponde a lista de exercicios");
                        Console.ReadKey();
                        break;
                }
            } while (ValorExercicios != 0);
            return 0;
        }
    }
}
