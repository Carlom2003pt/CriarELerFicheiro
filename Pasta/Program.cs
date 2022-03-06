using System;
using System.IO;

namespace Pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathCarlos= "d:\\Carlos\\f2.txt";
            string pathCarlosF2 = "d:\\Carlos\\f2.1.txt";
            string pathCarlosF3 = "d:\\Carlos\\f3.txt";
            string pathCarlosF4 = "d:\\Carlos\\f4.txt";
            //criar diretoria/pasta
            string NewPasta = @"d:\Carlos";
            if (!Directory.Exists(NewPasta))
            {
                Directory.CreateDirectory(NewPasta);
                Console.WriteLine("1. Nova pasta criada com sucesso: " + NewPasta);
            }
            else
            {
                Console.WriteLine("Pasta Já Existe!");
            }

            if (!File.Exists(pathCarlos))
            {
                using (StreamWriter sw = File.CreateText(pathCarlos))
                {
                    sw.WriteLine("M5 - Estruturas de dados estáticas");
                    Console.WriteLine("Ficheiro" + pathCarlos + "criado com sucesso!");

                }
            }
            else
            {
                Console.WriteLine("Ficheiro Já Existe!");
            }

            if (!File.Exists(pathCarlosF2))
            {
                using (StreamWriter sw = File.CreateText(pathCarlosF2))
                {
                    sw.WriteLine("M5 - Estruturas de dados compostas");
                    Console.WriteLine("Ficheiro" + pathCarlosF2 + "criado com sucesso!");

                }
            }
            else
            {
                Console.WriteLine("Ficheiro Já Existe!");
            }

            if (!File.Exists(pathCarlosF3))
            {
                using (StreamWriter sw = File.CreateText(pathCarlosF3))
                {
                    sw.WriteLine("M6 - Estruturas de dados Dinâmicas");
                    Console.WriteLine("Ficheiro" + pathCarlosF3 + "criado com sucesso!");

                }
            }
            else
            {
                Console.WriteLine("Ficheiro Já Existe!");
            }

            if (!File.Exists(pathCarlosF4))
            {
                using (StreamWriter sw = File.CreateText(pathCarlosF4))
                {
                    sw.WriteLine("M7 - Tratamento de ficheiros");
                    Console.WriteLine("Ficheiro" + pathCarlosF4 + "criado com sucesso!");

                }
            }
            else
            {
                Console.WriteLine("Ficheiro Já Existe!");
            }

            
            using (StreamReader sr = File.OpenText(pathCarlos))
            {
                Console.WriteLine("2.Leitura do ficheiro " + pathCarlos);
                 string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            using (StreamReader sr = File.OpenText(pathCarlosF2))
            {
                Console.WriteLine("2.Leitura do ficheiro " + pathCarlosF2);
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            using (StreamReader sr = File.OpenText(pathCarlosF3))
            {
                Console.WriteLine("2.Leitura do ficheiro " + pathCarlosF3);
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            using (StreamReader sr = File.OpenText(pathCarlosF4))
            {
                Console.WriteLine("2.Leitura do ficheiro " + pathCarlosF4);
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
