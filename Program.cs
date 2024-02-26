// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o tamanho da senha desejada:");
        int length = Convert.ToInt32(Console.ReadLine());

        string data = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789~`!@#$%^&*()_-+=[{}]|;:'/.,<>";
        List<char> listaCaracteres = new List<char>();

        foreach(char c in data)
        {
            listaCaracteres.Add(c);
        }

        Random random = new Random();
        string password = "";

        for (int i = 0; i < length; i++)
        {
            int index = random.Next(listaCaracteres.Count);
            password += listaCaracteres[index];
        }

        Console.WriteLine("Senha Gerada: " + password);
    }
}