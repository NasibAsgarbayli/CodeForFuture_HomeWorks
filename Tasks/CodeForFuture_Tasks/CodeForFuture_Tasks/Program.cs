using System;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using CodeForFuture_Tasks.Exceptions;
using CodeForFuture_Tasks.Extensions;
using CodeForFuture_Tasks.Interfaces;
using CodeForFuture_Tasks.Models;
namespace CodeForFuture_Tasks
{
    internal class Program
    {
        #region CodeTaskAboutDelegate
        public static List<string> FilterStrings(List<string> items, Predicate<string> condition)
        {
            List<string> result = new List<string>();

            foreach (string item in items)
            {
                if (condition(item))  // Predicate true qaytarırsa, əlavə et
                {
                    result.Add(item);
                }
            }

            return result;
        }
        #endregion
        public delegate bool CheckNums(int num);
        public static bool CheckOdd(int num)
        {
            return num % 2 != 0;
        }
        public static bool CheckEven(int num)
        {
            return num % 2 == 0;
        }
        public static bool CheckGreaterThanFive(int num)
        {
            return num > 5;
        }
        public static int CheckAndSumNum(CheckNums del, int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                if (del(num))
                {
                    sum += num;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {

            #region LoginException
            string correctEmail = "test@mail.com";
            string correctPassword = "12345";

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Şifrə: ");
            string password = Console.ReadLine();

            try
            {
                if (email != correctEmail)
                    throw new LoginException("Email səhvdir!");

                if (password != correctPassword)
                    throw new LoginException("Şifrə səhvdir!");

                Console.WriteLine("Giriş uğurludur!");
            }
            catch (LoginException ex)
            {
                Console.WriteLine("Xəta: " + ex.Message);
            }
            #endregion
            #region ExceptionPractice
            try
            {
                Console.Write("Birinci ədədi daxil et: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("İkinci ədədi daxil et: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Nəticə: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Xəta: 0-a bölmək olmaz!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Xəta: Yalnız ədəd daxil edə bilərsən!");
            }
            finally
            {
                Console.WriteLine("Proqram bitdi.");
            }
            #endregion
            #region ReflectionPractice
            Type type = typeof(User);
            Console.WriteLine("Class adı: " + type.Name);

            Console.WriteLine("\nProperty-lər:");
            foreach (var prop in type.GetProperties())
            {
                Console.WriteLine("- " + prop.Name);
            }

            Console.WriteLine("\nMetodlar:");
            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Console.WriteLine("- " + method.Name);
            }

            Console.WriteLine("\nReflection uğurla işləyir!");
            #endregion
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(CheckAndSumNum(CheckOdd, nums));
            Console.WriteLine(CheckAndSumNum(CheckEven, nums)); 
            Console.WriteLine(CheckAndSumNum(CheckGreaterThanFive, nums));
            List<string> names = new List<string> { "Ali", "Ismayil", "Aydan", "Ramin", "Afaq" };

            List<string> filtered = FilterStrings(names, x => x.StartsWith("A"));

            Console.WriteLine("A ilə başlayan adlar:");
            foreach (string name in filtered)
            {
                Console.WriteLine(name);
            }
            //ICalculation calc = new Calculation();

            //Console.Write("Birinci ədədi daxil edin: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("İkinci ədədi daxil edin: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Əməliyyatı daxil edin (+, -, *, /): ");
            //string operation = Console.ReadLine();

            //double result = calc.Calculate(num1, num2, operation);

            //Console.WriteLine($"Nəticə: {result}");
            //int a = 3;
            //Console.WriteLine(a.Pow(4));

            //Console.Write("Ededi daxil edin: ");
            // 1) İlk hərfi böyük, qalanları kiçik et
            //#region Out, String, StringBuilder Tasks
            //string text1 = "hello world";
            //Console.WriteLine(CapitalizeWords(text1)); // Hello World

            //// 2) Xüsusi simvolları sil
            //string text2 = "Hello@2025!";
            //Console.WriteLine(RemoveSpecialCharacters(text2)); // Hello2025

            //// 3) Sətir .com ilə bitib-bitmədiyini yoxla
            //string text3 = "example.com";
            //Console.WriteLine(EndsWithCom(text3)); // True

            //// 1) İlk hərfi böyük, qalanları kiçik edən metod
            //static string CapitalizeWords(string input)
            //{
            //    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            //    return ti.ToTitleCase(input.ToLower());
            //}

            //// 2) Xüsusi simvolları silən metod
            //static string RemoveSpecialCharacters(string input)
            //{
            //    return Regex.Replace(input, "[^a-zA-Z0-9]", "");
            //}

            //// 3) Sətirin .com ilə bitib-bitmədiyini yoxlayan metod
            //static bool EndsWithCom(string input)
            //{
            //    return input.EndsWith(".com");
            //}
            ////#endregion
            //MathOperations mathOps = new MathOperations();
            //Console.Write("Müsbət ədəd daxil edin: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int factorial = mathOps.CalculateFactorial(number);
            //if (factorial != -1)
            //    Console.WriteLine($"{number}! = {factorial}");

            //AuthService auth = new AuthService();

            //Console.Write("Email daxil edin: ");
            //string email = Console.ReadLine();

            //Console.Write("Şifrə daxil edin: ");
            //string password = Console.ReadLine();

            //auth.Login(email, password);


            //Person person = new Person("Aslan", "Merdanli", 20, "Ehmedli");

            //Console.WriteLine(person.Name + " " + person.Surname + " " + person.Age + " " + person.Address);
            //// 2) RepeatNum
            //Console.WriteLine("---- RepeatNum ----");
            //var repeatedNums = RepeatNum(5, 4);
            //Console.WriteLine($"RepeatNum(5, 4): {string.Join(", ", repeatedNums)}");

            //// 3) RepeatText
            //Console.WriteLine("\n---- RepeatText ----");
            //string repeatedText = RepeatText("Hello ", 3);
            //Console.WriteLine($"RepeatText(\"Hello \", 3): {repeatedText}");

            //// 4) FormatUser
            //Console.WriteLine("\n---- FormatUser ----");
            //Console.WriteLine(FormatUser("Ismayil", 21));
            //Console.WriteLine(FormatUser("Leyla"));
            //Console.WriteLine(FormatUser("Aydin", 19, true));

            //// 5) Swap
            //Console.WriteLine("\n---- Swap ----");
            //int a = 10, b = 20;
            //Console.WriteLine($"Əvvəl: a={a}, b={b}");
            //Swap(ref a, ref b);
            //Console.WriteLine($"Sonra: a={a}, b={b}");

            //// 6) Average
            //Console.WriteLine("\n---- Average ----");
            //Console.WriteLine($"Average(1, 2, 3, 4, 5) = {Average(1, 2, 3, 4, 5)}");

            //// 7) MaxInt
            //Console.WriteLine("\n---- MaxInt ----");
            //Console.WriteLine($"MaxInt(7, 12) = {MaxInt(7, 12)}");
            //Console.WriteLine($"MaxInt(25, 9) = {MaxInt(25, 9)}");

            //// 8) MaxText
            //Console.WriteLine("\n---- MaxText ----");
            //Console.WriteLine($"MaxText(3, 8, 2, 15, 7) = {MaxText(3, 8, 2, 15, 7)}");


            #region Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.



            //int n = Convert.ToInt32(Console.ReadLine());
            //bool isPrime = true;

            //if (n == 0 || n == 1)
            //{
            //    Console.WriteLine($"{n} ne sade, ne de mürekkeb ededdir");
            //}
            //else
            //{
            //    if (n < 0)
            //    {
            //        Console.WriteLine("Menfi ededler üçün sadelik yoxlanmır");
            //    }
            //    else
            //    {
            //        for (int i = 2; i * i <= n; i++)
            //        {
            //            if (n % i == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }

            //        if (isPrime)
            //        {
            //            Console.WriteLine($"{n} ededi sade ededdir");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{n} ededi mürekkeb ededdir");
            //        }
            //    }
            //}


            #endregion
            #region Heap,Stack, Ref
            //// 1) Verilən ədədi təkrarlayır
            //static int[] RepeatNum(int n, int times)
            //{
            //    if (times <= 0) return Array.Empty<int>();
            //    var arr = new int[times];
            //    for (int i = 0; i < times; i++) arr[i] = n;
            //    return arr;
            //}

            //// 2) Verilən mətni təkrarlayır
            //static string RepeatText(string s, int times)
            //{
            //    if (times <= 0 || s == null) return string.Empty;
            //    var sb = new StringBuilder(s.Length * times);
            //    for (int i = 0; i < times; i++) sb.Append(s);
            //    return sb.ToString();
            //}

            //// 3) İstifadəçi məlumatını formatlayır
            //static string FormatUser(string name, int age = 0, bool upper = false)
            //{
            //    if (name == null) name = "";
            //    var shown = upper ? name.ToUpper() : name;
            //    return age > 0 ? $"Name: {shown}, Age: {age}" : $"Name: {shown}";
            //}

            //// 4) İki ədədin yerini dəyişir
            //static void Swap(ref int a, ref int b)
            //{
            //    int t = a; a = b; b = t;
            //}
            //// 5) Verilən ədədlərin ortasını tapır
            //static double Average(params int[] nums)
            //{
            //    if (nums == null || nums.Length == 0) return 0.0;
            //    long sum = 0;
            //    for (int i = 0; i < nums.Length; i++) sum += nums[i];
            //    return (double)sum / nums.Length;
            //}
            //// 6) İki ədəddən ən böyüyünü qaytarır
            //static int MaxInt(int a, int b) => a >= b ? a : b;

            //// 7) Massivdəki ən böyük ədədi qaytarır
            //static int MaxText(params int[] arr)
            //{
            //    if (arr == null || arr.Length == 0) return int.MinValue;
            //    int m = arr[0];
            //    for (int i = 1; i < arr.Length; i++) if (arr[i] > m) m = arr[i];
            //    return m;
            //}

            #endregion







            #region Array, OOP, Class Tasks
            //     var obj = new
            //     {
            //         name = "Nesib",
            //         surname = "Asgarbayli",
            //         age = 19,
            //         address = "Ehmedli Xezer"
            //     };



            //     int[,] numbers = new int[3, 4]
            //     {
            //         {1,2,3,4 },
            //         {5,6,7,8 },
            //         {9,10,11,12 }
            //     };

            //     int[,] numbers2 =
            //{
            //         {1,2,3,4 },
            //         {5,6,7,8 },
            //         {9,10,11,12 }
            //};


            #endregion
            // }
            // public class Person
            // {
            //     public string Name { get; set; }
            //     public string Surname { get; set; }
            //     public int Age { get; set; }
            //     public string Address { get; set; }
            //     public Person(string name, string surname, int age, string address) : this()
            //     {
            //         Name = name;
            //         Surname = surname;
            //         Age = age;
            //         Address = address;
            //     }

            //     public Person()
            //     {
            //         Name = "Nesib";
            //         Surname = "Asgarbayli";
            //         Age = 19;
            //         Address = "Ehmedli Xezer";
            //     }
            //     public void GetInfo()
            //     {
            //         Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Address: {Address}");
            //     }



            // }


            //public class MathOperations
            // {

            //     public int CalculateFactorial(int n)
            //     {
            //         if (n < 0)
            //         {
            //             Console.WriteLine("Menfi ədədlərin faktorialı yoxdur!");
            //             return -1;
            //         }

            //         int result = 1;
            //         for (int i = 1; i <= n; i++)
            //         {
            //             result *= i;
            //         }
            //         return result;
            //     }
            // }

            //public class AuthService
            // {

            //     public void Login(string email, string password)
            //     {
            //         if (email == "emil@code.edu.az" && password == "12345")
            //         {
            //             Console.WriteLine("Giriş olundu ");
            //         }
            //         else
            //         {
            //             Console.WriteLine("Mail və yaxud parol səhvdir ");
            //         }
            //     }
            // }
        }
    } 
}












