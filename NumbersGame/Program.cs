// Jing Zhang (.NET23)

using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Välkommen! Jag tänker på ett nummer. " +
            "Kan du gissa vilket (mellan 1 och 20)? Du får fem försök.");
        CheckGuess();
    }
    static void CheckGuess()
    {
        Random random = new Random();
        int number = random.Next(1, 21);
        int totalAttempt = 5;
        for (int i = 1; i <= totalAttempt; i++)
        {
            string input = Console.ReadLine();

            int inputNumber = int.Parse(input);

            if (inputNumber < number)
            {
                Console.WriteLine("Tyvärr, du gissade för lågt!");
            }
            else if (inputNumber > number)
            {
                Console.WriteLine("Tyvärr, du gissade för högt!");
            }
            else
            {
                Console.WriteLine("Wohoo! Du klarade det!");
                break;
            }
            if (i == totalAttempt)
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
            }
        }
    }
}