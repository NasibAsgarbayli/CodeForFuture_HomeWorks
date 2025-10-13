
#region Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
using System.Text;

//Console.Write("Ededi daxil edin: ");

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
// 1) Verilən ədədi təkrarlayır
static int[] RepeatNum(int n, int times)
{
    if (times <= 0) return Array.Empty<int>();
    var arr = new int[times];
    for (int i = 0; i < times; i++) arr[i] = n;
    return arr;
}

// 2) Verilən mətni təkrarlayır
static string RepeatText(string s, int times)
{
    if (times <= 0 || s == null) return string.Empty;
    var sb = new StringBuilder(s.Length * times);
    for (int i = 0; i < times; i++) sb.Append(s);
    return sb.ToString();
}

// 3) İstifadəçi məlumatını formatlayır
static string FormatUser(string name, int age = 0, bool upper = false)
{
    if (name == null) name = "";
    var shown = upper ? name.ToUpper() : name;
    return age > 0 ? $"Name: {shown}, Age: {age}" : $"Name: {shown}";
}

// 4) İki ədədin yerini dəyişir
static void Swap(ref int a, ref int b)
{
    int t = a; a = b; b = t;
}
// 5) Verilən ədədlərin ortasını tapır
static double Average(params int[] nums)
{
    if (nums == null || nums.Length == 0) return 0.0;
    long sum = 0;
    for (int i = 0; i < nums.Length; i++) sum += nums[i];
    return (double)sum / nums.Length;
}
// 6) İki ədəddən ən böyüyünü qaytarır
static int MaxInt(int a, int b) => a >= b ? a : b;

// 7) Massivdəki ən böyük ədədi qaytarır
static int MaxText(params int[] arr)
{
    if (arr == null || arr.Length == 0) return int.MinValue;
    int m = arr[0];
    for (int i = 1; i < arr.Length; i++) if (arr[i] > m) m = arr[i];
    return m;
}


// 2) RepeatNum
Console.WriteLine("---- RepeatNum ----");
var repeatedNums = RepeatNum(5, 4);
Console.WriteLine($"RepeatNum(5, 4): {string.Join(", ", repeatedNums)}");

// 3) RepeatText
Console.WriteLine("\n---- RepeatText ----");
string repeatedText = RepeatText("Hello ", 3);
Console.WriteLine($"RepeatText(\"Hello \", 3): {repeatedText}");

// 4) FormatUser
Console.WriteLine("\n---- FormatUser ----");
Console.WriteLine(FormatUser("Ismayil", 21));
Console.WriteLine(FormatUser("Leyla"));
Console.WriteLine(FormatUser("Aydin", 19, true));

// 5) Swap
Console.WriteLine("\n---- Swap ----");
int a = 10, b = 20;
Console.WriteLine($"Əvvəl: a={a}, b={b}");
Swap(ref a, ref b);
Console.WriteLine($"Sonra: a={a}, b={b}");

// 6) Average
Console.WriteLine("\n---- Average ----");
Console.WriteLine($"Average(1, 2, 3, 4, 5) = {Average(1, 2, 3, 4, 5)}");

// 7) MaxInt
Console.WriteLine("\n---- MaxInt ----");
Console.WriteLine($"MaxInt(7, 12) = {MaxInt(7, 12)}");
Console.WriteLine($"MaxInt(25, 9) = {MaxInt(25, 9)}");

// 8) MaxText
Console.WriteLine("\n---- MaxText ----");
Console.WriteLine($"MaxText(3, 8, 2, 15, 7) = {MaxText(3, 8, 2, 15, 7)}");
#endregion
