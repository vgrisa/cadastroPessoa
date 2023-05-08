using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exec_9
{
    class Program
    {
        public static void Cadastro()
        {
            string nome, email, telefone, rg;
            string caminhoArquivo = "C:\\Users\\7971524\\Desktop\\Allog\\C#\\1 - Inicio\\ConsoleApp1\\cadastro.txt";
            try
            {
                Console.WriteLine("Escreva seu Nome:");
                nome = Console.ReadLine();
                Console.WriteLine("Escreva seu Email:");
                email = Console.ReadLine();
                Console.WriteLine("Escreva seu Telefone:");
                telefone = Console.ReadLine();
                Console.WriteLine("Escreva seu Rg:");
                rg = Console.ReadLine();


                StreamWriter arquivo = File.AppendText(caminhoArquivo);
                arquivo.WriteLine($"{nome}-{email}-{telefone}-{rg}");
                arquivo.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Algo deu errado, tente novamente");
            }
            Console.WriteLine();
            try
            {
                string linha, nomeN, emailN, telefoneN, rgN;
                string[] separadas;
                StreamReader sr = new StreamReader(caminhoArquivo);
                linha = sr.ReadLine();
                while (linha != null)
                {
                    separadas = linha.Split('-');
                    nomeN = separadas[0];
                    emailN = separadas[1];
                    telefoneN = separadas[2];
                    rgN = separadas[3];
                    Console.WriteLine($"Nome: {nomeN} - Email: {emailN} - Telefone: {telefoneN} - RG: {rgN}");
                    linha = sr.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Algo deu errado, tente novamente");
            }
        }
        static void Main(string[] args)
        {
            //exercicio 9
            Cadastro();

            Console.Read();
        }
    }
}
