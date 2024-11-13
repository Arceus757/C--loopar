internal class Program
{
    private static void Main(string[] args)
    {
        // uppgift 1
        // for (int i = 1; i <= 100; i++)
        // {
        //     if (i % 2 != 0)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }

        // uppgift 2
        // for (int i = 5; i >= 1; i--)
        // {
        //     for (int j = 1; j <= i; j++)
        //     {
        //         Console.Write("*");
        //     }
        //     Console.WriteLine();
        // }

        // uppgift 3
        // string password = "PasswordGG";
        // int attempts = 0;
        // string userGuess = "";

        // while (userGuess != password)
        // {
        //     Console.Write("Enter your guess for the password: ");
        //     userGuess = Console.ReadLine();
        //     attempts++;

        //     if (userGuess != password)
        //     {
        //         Console.WriteLine("Incorrect password, please try again.");
        //     }
        // }

        // Console.WriteLine($"Correct! It took you {attempts} attempts to guess the password.");


        // uppgift 4
        Console.Write("Enter Balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter goal: ");
        double goal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter interest: ");
        double interestRate = Convert.ToDouble(Console.ReadLine());

        int years = 0;

        while (balance < goal)
        {
            balance += balance * (interestRate / 100);
            years++;
        }

        Console.WriteLine($"It will take {years} years to reach your goal of {goal}$");

    }
}