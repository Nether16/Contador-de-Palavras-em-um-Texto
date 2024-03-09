internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escreva seu texto para saber quantas palavras a nele");
        string texto = Console.ReadLine();

        char[] numletras = texto.ToCharArray();
        int numespaços = texto.Count(Char.IsWhiteSpace);

        Console.WriteLine(numletras.Length - numespaços);
    }
}