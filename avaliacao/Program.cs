using System;

namespace avaliacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, nota4, nota5, mediadaturma, nota;
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
                nota = nota1 = int.Parse(Console.ReadLine());
                Console.WriteLine("DIGITE A NOTA DO: " + nome2);
                nota = nota2 = int.Parse(Console.ReadLine());
                Console.WriteLine("DIGITE A NOTA DO: " + nome3);
                nota = nota3 = int.Parse(Console.ReadLine());
                Console.WriteLine("DIGITE A NOTA DO: " + nome4);
                nota = nota4 = int.Parse(Console.ReadLine());
                Console.WriteLine("DIGITE A NOTA DO: " + nome5);
                nota = nota5 = int.Parse(Console.ReadLine());

                Console.WriteLine(nome1 + " NOTA: " + nota1);
                Console.WriteLine(nome2 + " NOTA: " + nota2);
                Console.WriteLine(nome3 + " NOTA: " + nota3);
                Console.WriteLine(nome4 + " NOTA: " + nota4);
                Console.WriteLine(nome5 + " NOTA: " + nota5);

                mediadaturma = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

                if (nota1 < 5)
                {
                    Console.WriteLine(nome1 + " VOCÊ ESTÁ REPROVADO " + "SUA NOTA FOI, " + nota1 + " A MEDIA DA TURMA FOI: " + mediadaturma);

                }
                if (nota2 <5)
                {
                    Console.WriteLine(nome2 + " VOCÊ ESTÁ REPROVADO " + "SUA NOTA FOI, " + nota2 +" A MEDIA DA TURMA FOI: " + mediadaturma);
                }
                if (nota3 < 5)
                {
                    Console.WriteLine(nome3 + " VOCÊ ESTÁ REPROVADO " + " SUA NOTA FOI, " + nota3 + " A MEDIA DA TURMA FOI: " + mediadaturma);
                }
                if (nota4 < 5)
                {
                    Console.WriteLine(nome4 + " VOCÊ ESTÁ REPROVADO " + "SUA NOTA FOI, " + nota4 + " A MEDIA DA TURMA FOI: " + mediadaturma);
                }
                if (nota5 <5)
                {
                    Console.WriteLine(nome5 + " VOCÊ ESTÁ REPROVADO " + "SUA NOTA FOI, "+ nota5 +" A MEDIA DA TURMA FOI: " + mediadaturma);
                }
                if (nota1 >= 5)
                {
                    Console.WriteLine(nome1 + "  VOCE ESTÁ APROVADO " + " SUA NOTA FOI, " + nota1 + "A MEDIA DA SALA FOI: " + mediadaturma);
                }
                if (nota2 >= 5)
                {
                    Console.WriteLine(nome2 + " VOCE ESTÁ APROVADO " + " SUA NOTA FOI, " + nota2 + " A MEDIA DA SALA FOI: " + mediadaturma);
                }
                if (nota3 >= 5)
                {
                    Console.WriteLine(nome3 + " VOCE ESTÁ APROVADO " + "SUA NOTA FOI, " + nota3 + " A MEDIA DA SALA FOI: " + mediadaturma);
                }
                if (nota4 >= 5)
                {

                    Console.WriteLine(nome4 + " VOCE ESTÁ APROVADO" + "SUA NOTA FOI, " + nota4 + " A MEDIA DA SALA FOI: " + mediadaturma);
                }
                if (nota5 >= 5)
                {
                    Console.WriteLine(nome5 + " VOCE ESTÁ APROVADO " + "SUA NOTA FOI, " + nota5 + "A MEDIA DA SALA FOI:" + mediadaturma);
                }

                // aprovados = aprovados*100/5
                //reprovados = REPROVADOS % APROVADOS

                Console.WriteLine("\nDESEJA FAZER UMA NOVA CONSULTA? sim ou não");
                retorno = Console.ReadLine();

            } while (retorno == "sim" || retorno == "SIM");

            Console.Clear();
        }

    }




}
































