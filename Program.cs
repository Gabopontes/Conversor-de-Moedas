namespace ConversorDeMoedas;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Conversor de Medas");
        Console.WriteLine();
        Console.WriteLine("Para qual moeda você deseja converter?");
        Console.WriteLine("1 - Dolar Americano");
        Console.WriteLine("2 - Euro Europeu");
        Console.WriteLine("3 - Iene Japonês");
        Console.WriteLine("4 - Libra Inglesa");
        Console.WriteLine("0 - Sair");
        var opção = int.Parse(Console.ReadLine());

        switch (opção)
        {
            case 1:
                ConversorDeMoeda.Dolar();
                break;
            case 2:
                ConversorDeMoeda.Euro();
                break;
            case 3:
                ConversorDeMoeda.Iene();
                break;
            case 4:
                ConversorDeMoeda.Libra();
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Main();
                break;
        }
    }
}
