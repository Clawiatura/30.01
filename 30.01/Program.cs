// Задание уровня Новичок:
//1
//2
//Console.WriteLine("Введите ваше имя: ");
//string name = Console.ReadLine();
//Console.WriteLine(name);

//3
//Console.WriteLine("Введите первое число: ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int b = int.Parse(Console.ReadLine());
//int res = a + b;
//Console.WriteLine(res);

//4
//Console.WriteLine("Введите число: ");
//int a = int.Parse(Console.ReadLine());
//if (a % 2 == 0) Console.WriteLine("Число четное");
//else Console.WriteLine("Нечетное");

//5
//Console.WriteLine("Введите первое число: ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите третье число: ");
//int c = int.Parse(Console.ReadLine());




//int maxNumber = a;
//if (b > a && b>c) maxNumber = b;
//else if (c > a && b > a && b<c) maxNumber = c;
//Console.WriteLine(maxNumber);


//Задания уровня База

//6
//Console.WriteLine("Введите число: ");
//int x = int.Parse(Console.ReadLine());
//long Factorial (int y)
//{
//    long f = 1;
//    for (int i = 0; i <= y; i++) f *= i;
//    return f;
//}
//Console.WriteLine(Factorial(x));



//7
//long summa (int x)
//{
//    long sum = 0;
//    for (int i = 1; i <= x; i++) sum += i;
//    return sum;

//}
//Console.WriteLine(summa(100));



//Console.WriteLine("Введите текст ");
//string text = Console.ReadLine();
//Console.WriteLine((int)text.Length);




//9
//Console.WriteLine("Введите число: ");
//int x = int.Parse(Console.ReadLine());
//bool result = true;
//for (int i = 2; i <x ; i++)
//{
//    if(x% i ==0) result = false;
//    break;
//}
//if (result)
//{
//    Console.WriteLine("Число простое");

//}
//else
//{
//    Console.WriteLine("Число непростое");
//}


//10
//Console.WriteLine("Введите число 1: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число 2: ");
//int number2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число 3: ");
//int number3 = int.Parse(Console.ReadLine());
//int avg = (number1 + number2 + number3) / 3;
//Console.WriteLine(avg);

//11

//Console.WriteLine("Введите первое число: ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите третье число: ");
//int c = int.Parse(Console.ReadLine());




//int minNumber = a;
//if (b < a && b < c) minNumber = b;
//else if (c < a && b < a && c < b ) minNumber = c;
//Console.WriteLine(minNumber);

//12




//Console.WriteLine("Введите текст: ");
//string str = Console.ReadLine()!;
//string res = "";
//for (int i = str.Length-1; i >=0; i--)
//{
//    res += str[i];
//}
//Console.WriteLine(res);

//13

//using System.Diagnostics.Tracing;

//Console.WriteLine("Введите слово: ");
//string text = Console.ReadLine();
//int startIndex = 0;
//int maxIndex = (int)text.Length;
//if (text[startIndex]== text[maxIndex-1])
//{
//    startIndex++;
//    maxIndex--;
//}
//if (text[startIndex]== text[maxIndex-1])
//{
//    Console.WriteLine("Палиндром");
//}
//else Console.WriteLine("Не палиндром");

// Уровень Любитель
//14
//Console.WriteLine("Введите число: ");
//int number = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = 1; i < number; i++)
//{
//    if (number % i == 0)
//        sum += i;
//}
//if (sum == number) Console.WriteLine("Число совершенное");
//else Console.WriteLine("Несовершенное");

//15

//for(int i = 1; i <= 100; i++)
//{
//    int k =0;
//    for(int j = 2; j < i; j++)
//    {
//        if (i % j == 0) k++;
//    }
//    if (k == 0) Console.Write(i + " ");
//}




//16


//int sum = 0;
//for (int i = 2; i <= 100; i+=2)
//{

//        sum+=i;

//}
//Console.Write(sum);

//17
//Console.WriteLine("Введите текст");
//string text = Console.ReadLine();
//string abc = "";
//for (int i = (int)'A'; i <(int)'z'; i++)
//{
//   if (Char.IsLetter((char)i)) abc += (char)i;

//}
//if(abc == text)
//{
//    Console.WriteLine("Содержит все буквы алфавита");
//}
//else
//{
//    Console.WriteLine("Не содержит все буквы");
//}

//18
//Console.WriteLine("Введите первое число: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int number2 = int.Parse(Console.ReadLine());
//if (number1 != 0 && number2 != 0)
//    if (number1 > number2)
//    {
//        number1 = number1 % number2;
//        Console.WriteLine(number1);
//    }
//else
//    {
//        number2 = number2 % number1;
//        Console.WriteLine(number2);
//    }
//19
//int sum = 0;
//while (true)
//    {
//    Console.WriteLine("Введите число: ");
//    int number = int.Parse(Console.ReadLine());

//    bool test = true;
//    if (number >= 0)
//    {
//        sum += number;

//    }
//    else if (number < 0)
//              {
//        break;
//    }

//}
//Console.WriteLine(sum);

// Уровень зануда
//20 //21 //22 //23




//int[] mas = new int[8];
//int sum = 0;
//int x = 0;
//int max = 0;
//int min = 0;
//for (int i = 1; i < 8; i++)
//{


//    sum += i;
//    if (mas[i] % 2 == 0)
//    {
//        x++;
//    }
//    if (max < mas[i])
//    {
//        max = mas[i];
//    }
//    if (min > mas[i])
//    {
//        min = mas[i];
//    }


//}

//Console.WriteLine(sum);
//Console.WriteLine(x);
//Console.WriteLine(max);
//Console.WriteLine(min);

//24


//int[] mas = new int[22];
//int startIndex = 0;
//int maxIndex = mas.Length;
//for (int i = 1; i < 9; i++)
//{


//    if (mas[startIndex] == mas[maxIndex - 1])
//    {
//        startIndex++;
//        maxIndex--;
//    }


//}
//25 //26




//int[,] mas = new int[5, 5] {{2,4,6,7,8 },
//                            {1,3,5,7,9 },
//                            {2,5,6,9,1},
//                            {2,3,6,8,1 },
//                            {5,2,7,9,8}};
//int sum = 0;
//for (int i = 0; i <5; i++)
//{
//    sum += mas[0, i];



//}
//Console.Write(sum +" "); // и так для каждой строки создаем цикл(можно еще создать функцию и вызывать её)











//27


//int[,] mas = new int[5, 5] {{2,4,6,7,8 },
//                            {1,3,5,7,9 },
//                            {2,5,6,9,1 },
//                            {2,3,6,8,1 },
//                            {5,2,7,9,8}};
//int sum = 0;
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        i++;
//        if (mas[i-1, j] == mas[0,0] || mas[i-1, j] == mas[1,1] || mas[i - 1, j] == mas[2,2] || mas[i - 1, j] == mas[3,3] || mas[i - 1, j] == mas[4,4])
//        { sum += mas[i - 1  , j]; }

//    }



//}
//Console.Write(sum);


//28 /
//int[][] mas = new int[][] {
//new int[] {7,-4,22,-12},
//new int[] {1},
//new int[] {13,-20,-6,-9 },
//new int[] {0,16,5}
//};



//29 //30//31
//int[][] mas = new int[][] {
//new int[] {7,-4,22,-12},
//new int[] {1},
//new int[] {13,-20,-6,-9 },
//new int[] {0,16,5}
//};
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        Console.Write(mas[i][j] + " ");
//    }
//    Console.WriteLine();

//}


//for (int i = 0; i < mas.Length; i++)
//{
//    double sum = 0;
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        sum += mas[i][j];
//    }
//    double avg = sum / mas[i].Length;
//    Console.WriteLine( avg);
//}



//for (int i = 0; i < mas.Length; i++)
//{
//    int temp = mas[0][3];
//    mas[0][3] = mas[2][3];
//    temp = mas[2][3];
//}
//    for (int y = 0; y < mas.Length; y++)
//    {
//        for (int j = 0; j < mas[y].Length; j++)
//        {
//            Console.Write(mas[y][j] + " ");
//        }
//        Console.WriteLine();

//    }








//int min = 0;
//int max = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    min = mas[i].Min();
//    max = mas[i].Max();


//}
//Console.WriteLine(min);
//Console.WriteLine(max);


//32
//int proizvidenie(int x, int y)
//{
//    int proizv = x * y;
//    return proizv;
//}
//
//33

//Console.WriteLine("Введите число: ");
//int b = int.Parse(Console.ReadLine());
//Console.Write(numberUseer(b));
//bool numberUseer(int x)
//{
//    bool result = true;
//    for (int i = 2; i < x; i++)
//    {
//        if (x % i == 0) result = false;
//        break;
//    }
//    if (result)
//    {
//        Console.WriteLine("Число простое");
//        return true;

//    }
//    else
//    {
//        Console.WriteLine("Число непростое");
//        return false;
//    }

//}
//34


//Console.WriteLine("Введите текст");
//string text = Console.ReadLine();
//Console.WriteLine(UserText(text));

//bool UserText(string textUser)
//    {
//    int startIndex = 0;
//    int maxIndex = (int)text.Length;
//    if (text[startIndex] == text[maxIndex - 1])
//    {
//        startIndex++;
//        maxIndex--;
//    }
//    if (text[startIndex] == text[maxIndex - 1])
//    {
//        return true;



//    }
//    else Console.WriteLine("Не палиндром");
//    return false;
//}

//35.Написать локальную функцию для вычисления факториала числа.

//Console.WriteLine("Введите число: ");
//int x = int.Parse(Console.ReadLine());
//long Factorial (int y)
//{
//    long f = 1;
//    for (int i = 0; i <= y; i++) f *= i;
//    return f;
//}

//36. Создать локальную функцию для нахождения наибольшего общего
//делителя двух чисел.
//Console.WriteLine("Введите первое число: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int number2 = int.Parse(Console.ReadLine());
//int avd(int x, int y)
//{
//    if (number1 != 0 && number2 != 0)
//    {
//        if (number1 > number2)
//        {
//            number1 = number1 % number2;

//        }
//        else

//        {
//            number2 = number2 % number1;

//        }

//    }
//    return number1;
//}
//    Console.WriteLine(avd(number1, number2));




//37. Создать класс для представления геометрической фигуры
//(например, прямоугольника) и методы для вычисления ее периметра и
//площади.
//public class Per
//{
//    public static double Perimetr(double x, double y, double z, double w)
//    {
//        return x + y + z + w;
//    }
//    public static double Plowad(double x, double y)
//    { return x * y; }
//}
//38. Реализовать класс для работы с числами и методы для выполнения
//арифметических операций.
//public class MathOperations
//{
//    public static double CalculateAverage(int[] numbers)
//    {
//        double sum = 0;
//        foreach (int num in numbers)
//        {
//            sum += num;
//        }
//        return sum / numbers.Length;
//    }

//    public static bool IsPrime(int number)
//    {
//        if (number / 1 == number && number / number == 1) return true;
//        return false;
//    }

//    public static bool IsEven(int number)
//    {
//        return number % 2 == 0;
//    }

//    public static bool IsOdd(int number)
//    {
//        return number % 2 != 0;
//    }

//    public static int CalculateFactorial(int number)
//    {
//        if (number == 0) return 1;
//        return number * CalculateFactorial(number - 1);
//    }

//    public static string ConvertToBinary(int number)
//    {
//        return Convert.ToString(number, 2);
//    }

//    public static string ConvertToHex(int number)
//    {
//        return Convert.ToString(number, 16);
//    }

//    public static double CalculatePower(double x, double y)
//    {
//        return Math.Pow(x, y);
//    }
//}
//39. Написать класс для управления банковским счетом с методами для
//пополнения и снятия средств.
//class BankAccount
//{
//    private decimal balance;

//    public BankAccount(decimal initialBalance)
//    {
//        balance = initialBalance;
//    }

//    public void Deposit(decimal amount)
//    {
//        balance += amount;
//        Console.WriteLine("Пополнение счета: " + amount);
//    }

//    public void Withdraw(decimal amount)
//    {
//        if (amount > balance)
//        {
//            Console.WriteLine("Недостаточно средств");
//        }
//        else
//        {
//            balance -= amount;
//            Console.WriteLine("Снятие наличных: " + amount);
//        }
//    }

//    public void CheckBalance()
//    {
//        Console.WriteLine("Текущий баланс: " + balance);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount account = new BankAccount(1000);

//        account.CheckBalance();
//        account.Deposit(500);
//        account.CheckBalance();
//        account.Withdraw(200);
//        account.CheckBalance();
//        account.Withdraw(1500);
//    }
//}
//40. Реализовать класс для работы с матрицами и методы для
//выполнения операций сложения, умножения и транспонирования.