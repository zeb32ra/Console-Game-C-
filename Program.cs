int input_number = 0;
Random rnd = new Random();

static void Menu()
{
    Console.WriteLine("Введите число из списка:\n" +
    "1 - Игра \"Угадай число\".\n" +
    "2 - \"Табица умножения\".\n" +
    "3 - \"Вывод делителей числа\".\n" +
    "4 - Выход из программы");
}


static string Guess_The_Number(int number, int correct_number)
{
    string Output = "";
    if (number == correct_number)
    {
        Output = "Ура, вы угадали чиcло!";
        return Output;
    }
    else if (number < correct_number)
    {
        Output = "Вы ввели число меньше загаданного. Пробуйте еще раз.";
        return Output;
    }
    else
    {
        Output = "Вы ввели число больше загаданного. Попробуйте еще раз.";
        return Output;
    }
}


static void Multiplication_Table()
{
    int[,] matrix = new int[10, 10];
    for (int r = 0; r < matrix.GetLength(0); r++)
    {
        for (int c = 0; c < matrix.GetLength(1); c++)
        {
            matrix[r, c] = (r + 1) * (c + 1);
        }
    }

    for (int r = 0; r < matrix.GetLength(0); r++)
    {
        for (int c = 0; c < matrix.GetLength(1); c++)
        {
            Console.Write(matrix[r, c] + "\t");
        }
        Console.WriteLine();
    }
}


static void All_Divisors(int number)
{
    List <int> divisors = new List<int>();
    for (int i = 1; i < (number + 1); i++)
    {
        if (number % i == 0)
        {
            divisors.Add(i);
        }
    }
    foreach (int i in divisors)
    {
        Console.Write(i + "\t");
    }
}


while (input_number != 4)
{
    Console.WriteLine("");
    Menu();
    input_number = Convert.ToInt32(Console.ReadLine());
    if (input_number == 1)
    {
        string result = "";
        int random_number = rnd.Next(101);
        Console.WriteLine("Введите чиcло");
        while (result != "Ура, вы угадали чиcло!")
        {
            int your_number = Convert.ToInt32(Console.ReadLine());
            result = Guess_The_Number(your_number, random_number);
            Console.WriteLine(result);
        }
    }
    else if (input_number == 2)
    {
        Console.WriteLine("");
        Multiplication_Table();
    }
    else if (input_number == 3)
    {
        Console.WriteLine("Введите число");
        int number_for_search = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        All_Divisors(number_for_search);
    }
    else
    {
        break;
    }
}