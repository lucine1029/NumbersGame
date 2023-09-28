// Jing Zhang (.NET23)

using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    static void Main(string[] args)
    {
        bool boo1 = true;
        bool boo2 = false;
        while (boo1)
        {
            do
            {
                Console.WriteLine("Välkommen! Kan du välja nivå på spelet?" +
                    "\n 1 Enkel nivå" +
                    "\n 2 Mellannivå" +
                    "\n 3 Svår nivå");
                string levelChoice = Console.ReadLine()!;
                switch (levelChoice)
                {
                    case "1":
                        Console.WriteLine("Du har valt 'Enkel nivå', nu kan du gissa ett tal mellan 1 och 10, och du får 6 försök! Lycka till!\n");
                        easyGame();
                        boo2 = false;
                        break;
                    case "2":
                        Console.WriteLine("Du har valt 'Mellannivå', nu kan du gissa ett tal mellan 1 och 25, och du får 5 försök! Lycka till!\n");
                        medianLevelGame();
                        boo2 = false;
                        break;
                    case "3":
                        Console.WriteLine("Du har valt 'Svår nivå', nu kan du gissa ett tal mellan 1 och 50, och du får 3 försök! Lycka till!\n");
                        hardGame();
                        boo2 = false;
                        break;
                    default:
                        Console.WriteLine("Du väljer fel nummer, välj igen!");
                        boo2 = true;
                        break;
                }
            } while (boo2);
            Console.WriteLine("Vill du spela igen? Y eller N?");
            string spelChoice = Console.ReadLine()!;
            if (spelChoice.ToUpper() == "Y" )
            {
                boo1 = true;
            }
            else
            {
                boo1 = false;
            }

        }
    }
    static void easyGame()
    {
        Random random = new Random();
        int number = random.Next(1, 11);
        int totalAttempt = 6;
        for (int i = 1; i <= totalAttempt; i++)
        {
            string input = Console.ReadLine()!;

            int inputNumber = int.Parse(input);
            int diff = Math.Abs(inputNumber - number);

            if (inputNumber < number)
            {
                if (diff <= 2)
                {
                    Console.WriteLine("Det bränns! Du är nära, men....");
                }
                else
                {
                    Console.WriteLine("Oh noooooo, det var långt ifran.");
                }
                tooLowAnswers();
            }
            else if (inputNumber > number)
            {
                if (diff <= 2)
                {
                    Console.WriteLine("Det bränns! Du är nära, men....");
                }
                else
                {
                    Console.WriteLine("Oh noooooo, det var långt ifran.");
                }
                tooHighAnswers();
            }
            else
            {
                Console.WriteLine("Wohoo! Du klarade det!");
                break;
            }
            if (i == totalAttempt)
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på 6 försök!");
            }
        }
    }

    static void medianLevelGame()
    {
        Random random = new Random();
        int number = random.Next(1, 26);
        int totalAttempt = 5;
        for (int i = 1; i <= totalAttempt; i++)
        {
            string input = Console.ReadLine()!;

            int inputNumber = int.Parse(input);
            int diff = Math.Abs(inputNumber - number);

            if (inputNumber < number)
            {
                if (diff <= 2)
                {
                    Console.WriteLine("Det bränns! Du är nära, men....");
                }
                else
                {
                    Console.WriteLine("Oh noooooo, det var långt ifran.");
                }
                tooLowAnswers();
            }
            else if (inputNumber > number)
            {
                if (diff <= 2)
                {
                    Console.WriteLine("Det bränns! Du är nära, men....");
                }
                else
                {
                    Console.WriteLine("Oh noooooo, det var långt ifran.");
                }
                tooHighAnswers();
            }
            else
            {
                Console.WriteLine("Wohoo! Du klarade det!");
                break;
            }
            if (i == totalAttempt)
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på 5 försök!");
            }
        }
    }
    static void hardGame()
    {
        Random random = new Random();
        int number = random.Next(1, 51);
        int totalAttempt = 3;
        for (int i = 1; i <= totalAttempt; i++)
        {
            string input = Console.ReadLine()!;

            int inputNumber = int.Parse(input);
            int diff = Math.Abs(inputNumber - number);

            if (inputNumber < number)
            {
                if (diff <= 2)
                {
                    Console.WriteLine("Det bränns! Du är nära, men....");
                }
                else
                {
                    Console.WriteLine("Oh noooooo, det var långt ifran.");
                }
                tooLowAnswers();
            }
            else if (inputNumber > number)
            {
                if (diff <= 2)
                {
                    Console.WriteLine("Det bränns! Du är nära, men....");
                }
                else
                {
                    Console.WriteLine("Oh noooooo, det var långt ifran.");
                }
                tooHighAnswers();
            }
            else
            {
                Console.WriteLine("Wohoo! Du klarade det!");
                break;
            }
            if (i == totalAttempt)
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på 3 försök!");
            }
        }
    }
    static void tooLowAnswers()
    {
        var tooLowAnswer = new List<string>
        {
            "Tyvärr, du gissade för lågt!",
            "Haha! Det var för lågt!",
            "Bra gissat, men det var för lågt",
            "OjOj, det var för lågt!",
        };
        Random random = new Random();
        int randomAnswerNum = random.Next(0, tooLowAnswer.Count);
        Console.WriteLine(tooLowAnswer[randomAnswerNum]);
    }
    static void tooHighAnswers()
    {
        var tooHighAnswer = new List<string>
        {
            "Tyvärr, du gissade för högt!",
            "Haha! Det var för högt!",
            "Bra gissat, men det var för högt",
            "OjOj, det var för högt!",
        };
        Random random = new Random();
        int randomAnswerNum = random.Next(0, tooHighAnswer.Count);
        Console.WriteLine(tooHighAnswer[randomAnswerNum]);
    }
}


