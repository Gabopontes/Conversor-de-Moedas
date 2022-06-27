namespace ConversorDeMoedas;

public class ConversorDeMoeda
{
    public static void Dolar()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Você está usando a moenda em REAL(BLR)!");
        Console.WriteLine("Digite o valor que voce deseja converter em Dolar Americano: ");
        var valor = decimal.Parse(Console.ReadLine());

        decimal cotaçãodolar = 4.50m;

        decimal resultado = valor / cotaçãodolar;
        Console.WriteLine($"O Valor de R${valor} Reais");
        Console.WriteLine($"Equeivale a ${resultado} Dolares Americanos");
        Console.WriteLine();
        Console.WriteLine("Precione qualquer tecla para volta ao Menu");
        Console.ReadKey();
        Program.Main();
    }
    public static void Euro()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Você está usando a moenda em REAL(BLR)!");
        Console.WriteLine("Digite o valor que voce deseja converter em Euro: ");
        var valor = decimal.Parse(Console.ReadLine());

        decimal cotaçãoEuro = 6.20m;

        decimal resultado = valor / cotaçãoEuro;
        Console.WriteLine($"O Valor de R${valor} Reais");
        Console.WriteLine($"Equeivale a €{resultado} Euros");
        Console.WriteLine();
        Console.WriteLine("Precione qualquer tecla para volta ao Menu");
        Console.ReadKey();
        Program.Main();
    }
    public static void Iene()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Você está usando a moenda em REAL(BLR)!");
        Console.WriteLine("Digite o valor que voce deseja converter em Iene: ");
        var valor = decimal.Parse(Console.ReadLine());

        decimal cotaçãoIene = 0.052m;

        decimal resultado = valor * cotaçãoIene;
        Console.WriteLine($"O Valor de R${valor} Reais");
        Console.WriteLine($"Equeivale a ¥{resultado} Ienes");
        Console.WriteLine();
        Console.WriteLine("Precione qualquer tecla para volta ao Menu");
        Console.ReadKey();
        Program.Main();

    }
    public static void Libra()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Você está usando a moenda em REAL(BLR)!");
        Console.WriteLine("Digite o valor que voce deseja converter em Libra: ");
        var valor = decimal.Parse(Console.ReadLine());

        decimal cotaçãoIene = 6.95m;

        decimal resultado = valor * cotaçãoIene;
        Console.WriteLine($"O Valor de R${valor} Reais");
        Console.WriteLine($"Equeivale a £{resultado} Libras");
        Console.WriteLine();
        Console.WriteLine("Precione qualquer tecla para volta ao Menu");
        Console.ReadKey();
        Program.Main();
    }
}