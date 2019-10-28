using System;
using System.IO;
using System.Globalization;
using ExercicioArquivos.Entities;

namespace ExercicioArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\marcos.paixao\Desktop\PROJETOS\Exemplos com Arquivos\file1.txt";
            try
            {
                using (StreamWriter sw = File.AppendText(@"C:\Users\marcos.paixao\Desktop\PROJETOS\Exemplos com Arquivos\BANANA.txt"))
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(path);
                        foreach (string line in lines)
                        {
                            string[] fields = line.Split(',');
                            string name = fields[0];
                            double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                            int quantity = int.Parse(fields[2]);

                            Produto prod = new Produto(name, price, quantity);
                            sw.WriteLine(prod.Nome + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                        }

                        Console.WriteLine("lINHAS IMPORTADAS COM SUCESSO!!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro foi detectado");
                Console.WriteLine(e.Message);
            }
        }
    }
}
