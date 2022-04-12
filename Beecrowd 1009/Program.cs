using System;
using System.Globalization;

class program
{
    static void Main(string[] args)
    {
        double salario, vendas, comissao = 0.15, total;
        string nome;

        nome  = Console.ReadLine();
        salario = double.Parse(Console.ReadLine());
        vendas = double.Parse(Console.ReadLine());
      

        total = ((vendas * comissao) + (salario));


        Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        Console.ReadLine();

        
    }
}