//namespace CodeAcademy_Tasks;
//public class ChooseMenu
//{
//    static void Main()
//    {
//        while (true)
//        {
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine("\n====== Menu ======");
//            Console.WriteLine("1. Eded 3 ve 7'ye bolunurmu?");
//            Console.WriteLine("2. Iki cut ededin cemi");
//            Console.WriteLine("3. n ve m araligindaki tek ededlerin cemi");
//            Console.WriteLine("4. Arraydaki tek ededlerin cemi");
//            Console.WriteLine("5. Arraydaki cut ededlerin cemi");
//            Console.WriteLine("6. Eded sade ya murekkebdir?");
//            Console.WriteLine("7. Fiqurlarin sahesini hesablamaq");
//            Console.WriteLine("8. Metndeki sozlerin ilk herfini boyutmek");
//            Console.WriteLine("9. Metnden xususi simvollari silmek");
//            Console.WriteLine("10. Metn .com ile bitir mi?");
//            Console.WriteLine("0. Cixis");
//            Console.ForegroundColor = ConsoleColor.DarkYellow;
//            Console.Write("Seciminizi edin: ");
//            Console.ResetColor();

//            int choice = Convert.ToInt32(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    CheckDivisibleBy3And7();
//                    break;
//                case 2:
//                    SumIfBothEven();
//                    break;
//                case 3:
//                    SumOddInRange();
//                    break;
//                case 4:
//                    SumOddInArray();
//                    break;
//                case 5:
//                    SumEvenInArray();
//                    break;
//                case 6:
//                    CheckPrimeNumber();
//                    break;
//                case 7:
//                    CalculateAreaMenu();
//                    break;
//                case 8:
//                    CapitalizeWords();
//                    break;
//                case 9:
//                    RemoveSpecialCharacters();
//                    break;
//                case 10:
//                    EndsWithCom();
//                    break;

//                case 0:
//                    return;
//                default:
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.WriteLine("Movcud olmayan secim etdiniz!");
//                    Console.ResetColor();
//                    break;
//            }
//        }
//    }
//    #region Methods
//    #region CheckDivisibleBy3And7
//    static void CheckDivisibleBy3And7()
//    {
//        Console.ForegroundColor = ConsoleColor.Cyan;
//        Console.Write("Ededi daxil edin: ");
//        Console.ResetColor();

//        int n = Convert.ToInt32(Console.ReadLine());
//        if (n % 3 == 0 && n % 7 == 0)
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine("Eded 3 e ve 7 ye qaliqsiz bolunur.");
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("Eded 3 e ve 7 ye qaliqsiz bolunmur.");
//        }
//        Console.ResetColor();
//    }
//    #endregion

//    #region SumIfBothEven
//    static void SumIfBothEven()
//    {
//        Console.ForegroundColor = ConsoleColor.Cyan;
//        Console.Write("Birinci ededi daxil edin: ");
//        Console.ResetColor();
//        int n = Convert.ToInt32(Console.ReadLine());

//        Console.ForegroundColor = ConsoleColor.Cyan;
//        Console.Write("Ikinci ededi daxil edin: ");
//        Console.ResetColor();
//        int m = Convert.ToInt32(Console.ReadLine());

//        if (n % 2 == 0 && m % 2 == 0)
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine($"Ededlerin cemi: {n + m}");
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("Ededlerden en az biri cut deyil.");
//        }
//        Console.ResetColor();
//    }
//    #endregion

//    #region SumOddInRange
//    static void SumOddInRange()
//    {
//        Console.ForegroundColor = ConsoleColor.Cyan;
//        Console.Write("Birinci ededi daxil edin: ");
//        Console.ResetColor();
//        int n = Convert.ToInt32(Console.ReadLine());

//        Console.ForegroundColor = ConsoleColor.Cyan;
//        Console.Write("Ikinci ededi daxil edin: ");
//        Console.ResetColor();
//        int m = Convert.ToInt32(Console.ReadLine());

//        if (n >= m)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("n ededi m ededinden kicik olmalidir.");
//        }
//        else
//        {
//            int sum = 0;
//            for (int i = n + 1; i < m; i++)
//            {
//                if (i % 2 != 0)
//                    sum += i;
//            }

//            if (sum == 0)
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("Verdiyiniz araliqda her hansi tek eded yerlesmir.");
//            }
//            else
//            {
//                Console.ForegroundColor = ConsoleColor.Green;
//                Console.WriteLine($"Tek ededlerin cemi: {sum}");
//            }
//        }
//        Console.ResetColor();
//    }
//    #endregion

//    #region SumOddInArray
//    static void SumOddInArray()
//    {
//        Console.ForegroundColor = ConsoleColor.Cyan;
//        Console.Write("Arrayin element sayini daxil edin: ");
//        Console.ResetColor();

//        int n = Convert.ToInt32(Console.ReadLine());
//        int[] numbers = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.Write($"Element {i + 1}-i daxil edin: ");
//            Console.ResetColor();
//            numbers[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        int sum = 0;
//        bool hasOdd = false;

//        foreach (var num in numbers)
//        {
//            if (num % 2 != 0)
//            {
//                sum += num;
//                hasOdd = true;
//            }
//        }

//        if (hasOdd)
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine($"Arraydaki tek ededlerin cemi: {sum}");
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("Arrayda hec bir tek eded yoxdur!");
//        }
//        Console.ResetColor();
//    }
//    #endregion

//    #region SumEvenInArray
//    static void SumEvenInArray()
//    {
//        Console.ForegroundColor = ConsoleColor.Cyan;
//        Console.Write("Arrayin element sayini daxil edin: ");
//        Console.ResetColor();

//        int n = Convert.ToInt32(Console.ReadLine());
//        int[] numbers = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.Write($"Element {i + 1}-i daxil edin: ");
//            Console.ResetColor();
//            numbers[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        int sum = 0;
//        bool hasEven = false;

//        foreach (var num in numbers)
//        {
//            if (num % 2 == 0)
//            {
//                sum += num;
//                hasEven = true;
//            }
//        }

//        if (hasEven)
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine($"Arraydaki cut ededlerin cemi: {sum}");
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("Arrayda hec bir cut eded yoxdur!");
//        }
//        Console.ResetColor();
//    }
//    #endregion

//    #region CheckPrimeNumber
//    static void CheckPrimeNumber()
//    {
//        Console.ForegroundColor = ConsoleColor.Cyan;
//        Console.Write("Ededi daxil edin: ");
//        Console.ResetColor();
//        int n = Convert.ToInt32(Console.ReadLine());
//        bool isPrime = true;

//        if (n == 0 || n == 1)
//        {
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine($"{n} ne sade, ne de mürekkeb ededdir!");
//        }
//        else if (n < 0)
//        {
//            Console.ForegroundColor = ConsoleColor.DarkYellow;
//            Console.WriteLine("Menfi ededler üçün sadelik yoxlanmır!");
//        }
//        else
//        {
//            for (int i = 2; i * i <= n; i++)
//            {
//                if (n % i == 0)
//                {
//                    isPrime = false;
//                    break;
//                }
//            }

//            if (isPrime)
//            {
//                Console.ForegroundColor = ConsoleColor.Yellow;
//                Console.WriteLine($"{n} ededi sade ededdir");
//            }
//            else
//            {
//                Console.ForegroundColor = ConsoleColor.Magenta;
//                Console.WriteLine($"{n} ededi mürekkeb ededdir");
//            }
//        }
//        Console.ResetColor();
//    }
//    #endregion

//    #region Area Methods Overloading

//    static void CalculateAreaMenu()
//    {
//        Console.ForegroundColor = ConsoleColor.DarkCyan;
//        Console.WriteLine("Sahesini hesablamaq istediyiniz fiquru secin:");
//        Console.ForegroundColor = ConsoleColor.Cyan;
//        Console.WriteLine("1. Rectangle");
//        Console.WriteLine("2. Square");
//        Console.ResetColor();

//        Console.Write("Your choice: ");
//        int figureChoice = Convert.ToInt32(Console.ReadLine());

//        switch (figureChoice)
//        {
//            case 1:
//                Console.ForegroundColor = ConsoleColor.DarkCyan;
//                Console.Write("Duzbucaqlinin enini daxil edin: ");
//                double width = Convert.ToDouble(Console.ReadLine());
//                Console.Write("Duzbucaqlinin hundurluyunu daxil edin: ");
//                double height = Convert.ToDouble(Console.ReadLine());
//                Console.ForegroundColor = ConsoleColor.Green;
//                Console.WriteLine($"Rectangle area: {Area(ref width, ref height)}");
//                Console.ResetColor();
//                break;

//            case 2:
//                Console.ForegroundColor = ConsoleColor.DarkCyan;
//                Console.Write("Kvadratin terefini daxil edin: ");
//                double side = Convert.ToDouble(Console.ReadLine());
//                Console.ForegroundColor = ConsoleColor.Green;
//                Console.WriteLine($"Square area: {Area(ref side)}");
//                Console.ResetColor();
//                break;

//            default:
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("Invalid choice!");
//                Console.ResetColor();
//                break;
//        }
//    }

//    static double Area(ref double a, ref double b)
//    {
//        return a * b;
//    }

//    static double Area(ref double side)
//    {
//        return side * side;
//    }
//    #endregion

//    #region RemoveSpecialCharacters
//    static void RemoveSpecialCharacters()
//    {
//        Console.ForegroundColor = ConsoleColor.Cyan;
//        Console.Write("Metni daxil edin: ");
//        Console.ResetColor();
//        string input = Console.ReadLine();

//        string result = "";
//        foreach (char ch in input)
//        {
//            if (char.IsLetterOrDigit(ch) || char.IsWhiteSpace(ch))
//            {
//                result += ch;
//            }
//        }

//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine("Netice: " + result);
//        Console.ResetColor();
//    }
//    #endregion

//    #region CapitalizeWords
//    static void CapitalizeWords()
//    {
//        Console.ForegroundColor = ConsoleColor.Cyan;
//        Console.Write("Metni daxil edin: ");
//        Console.ResetColor();
//        string input = Console.ReadLine();

//        string[] words = input.Split(' ');

//        for (int i = 0; i < words.Length; i++)
//        {
//            if (words[i].Length > 0)
//            {
//                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
//            }
//        }

//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine("Netice: " + string.Join(" ", words));
//        Console.ResetColor();
//    }
//    #endregion

//    #region EndsWithCom
//    static void EndsWithCom()
//    {
//        Console.ForegroundColor = ConsoleColor.Cyan;
//        Console.Write("Metni daxil edin: ");
//        Console.ResetColor();
//        string input = Console.ReadLine();

//        if (input.EndsWith(".com"))
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine("Daxil edilen metn .com ile bitir.");
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("Daxil edilen metn .com ile bitmir.");
//        }
//        Console.ResetColor();
//    }
//    #endregion

//    #endregion
//}
