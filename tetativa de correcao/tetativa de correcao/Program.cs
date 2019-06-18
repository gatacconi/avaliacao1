using System;

namespace tetativa_de_correcao
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, nota4, nota5, mediadaturma,aprovado=0,reprovado=0;
            string nome1, nome2, nome3, nome4, nome5, retorno;

            do
            {

                Console.WriteLine("DIGITE O NOME DO PRIMEIRO ALUNO");
                nome1 = (Console.ReadLine());
                Console.WriteLine("DIGITE O NOME DO SEGUNDO ALUNO");
                nome2 = (Console.ReadLine());
                Console.WriteLine("DIGITE O NOME DO TERCEIRO ALUNO");
                nome3 = (Console.ReadLine());
                Console.WriteLine("DIGITE O NOME DO QUARTO ALUNO");
                nome4 = (Console.ReadLine());
                Console.WriteLine("DIGITE O NOME DO QUINTO ALUNO");
                nome5 = (Console.ReadLine());

                Console.WriteLine("DIGITE A NOTA DO " + nome1);
                nota1 = int.Parse(Console.ReadLine());
                while (nota1 < 0 || nota1 > 10)
                {
                    Console.WriteLine("DIGITE A NOTA DO " + nome1);
                    nota1 = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("DIGITE A NOTA DO: " + nome2);
                nota2 = int.Parse(Console.ReadLine());
                while (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("DIGITE A NOTA DO " + nome2);
                    nota2 = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("DIGITE A NOTA DO: " + nome3);
                nota3 = int.Parse(Console.ReadLine());
                while (nota3 < 0 || nota3 > 10)
                {
                    Console.WriteLine("DIGITE A NOTA DO " + nome3);
                    nota3 = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("DIGITE A NOTA DO: " + nome4);
                nota4 = int.Parse(Console.ReadLine());
                while (nota4 < 0 || nota4 > 10)
                {
                    Console.WriteLine("DIGITE A NOTA DO " + nome4);
                    nota4 = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("DIGITE A NOTA DO: " + nome5);
                nota5 = int.Parse(Console.ReadLine());
                while (nota5 < 0 || nota5 > 10)
                {
                    Console.WriteLine("DIGITE A NOTA DO " + nome5);
                    nota5 = int.Parse(Console.ReadLine());
                }

                //calculo media
                mediadaturma = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

                //imprimir notas decisao
                if (nota1 < 5)
                {
                    Console.WriteLine(nome1 + " VOCÊ ESTÁ REPROVADO " + "SUA NOTA FOI, " + nota1 + " A MEDIA DA TURMA FOI: " + mediadaturma);
                    reprovado++;
                }
                else
                {
                    Console.WriteLine(nome1 + "  VOCE ESTÁ APROVADO " + " SUA NOTA FOI, " + nota1 + "A MEDIA DA SALA FOI: " + mediadaturma);
                    aprovado++;
                }
                if (nota2 < 5)
                {
                    Console.WriteLine(nome2 + " VOCÊ ESTÁ REPROVADO " + "SUA NOTA FOI, " + nota2 + " A MEDIA DA TURMA FOI: " + mediadaturma);
                    reprovado++;
                }
                else
                {
                    Console.WriteLine(nome2 + " VOCE ESTÁ APROVADO " + " SUA NOTA FOI, " + nota2 + " A MEDIA DA SALA FOI: " + mediadaturma);
                    aprovado++;
                }

                if (nota3 < 5)
                {
                    Console.WriteLine(nome3 + " VOCÊ ESTÁ REPROVADO " + " SUA NOTA FOI, " + nota3 + " A MEDIA DA TURMA FOI: " + mediadaturma);
                    reprovado++;
                }
                else
                {
                    Console.WriteLine(nome3 + " VOCE ESTÁ APROVADO " + "SUA NOTA FOI, " + nota3 + " A MEDIA DA SALA FOI: " + mediadaturma);
                    aprovado++;
                }

                if (nota4 < 5)
                {
                    Console.WriteLine(nome4 + " VOCÊ ESTÁ REPROVADO " + "SUA NOTA FOI, " + nota4 + " A MEDIA DA TURMA FOI: " + mediadaturma);
                    reprovado++;
                }
                else
                {
                    Console.WriteLine(nome4 + " VOCE ESTÁ APROVADO" + "SUA NOTA FOI, " + nota4 + " A MEDIA DA SALA FOI: " + mediadaturma);
                    aprovado++;
                }

                if (nota5 < 5)
                {
                    Console.WriteLine(nome5 + " VOCÊ ESTÁ REPROVADO " + "SUA NOTA FOI, " + nota5 + " A MEDIA DA TURMA FOI: " + mediadaturma);
                    reprovado++;
                }
                else
                {
                    Console.WriteLine(nome5 + " VOCE ESTÁ APROVADO " + "SUA NOTA FOI, " + nota5 + "A MEDIA DA SALA FOI:" + mediadaturma);
                    aprovado++;
                }

                aprovado = aprovado * 20;
                reprovado = reprovado * 20;

                Console.WriteLine("APROVADO: {0}%", aprovado);
                Console.WriteLine("REPROVADO: {0}%", reprovado);

                Console.WriteLine("\nDESEJA FAZER UMA NOVA CONSULTA? sim ou não");
                retorno = Console.ReadLine();

            } while (retorno == "sim" || retorno == "SIM");

            Console.Clear();
        }

    }




}