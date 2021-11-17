
// Почувствуй себя интерном
//  0. Вывести квадрат числа
//  1. По двум заданным числам проверять является ли первое квадратом второго
//  2. Даны два числа. Показать большее и меньшее число
//  3. По заданному номеру дня недели вывести его название
//  4. Найти максимальное из трех чисел
//  5. Написать программу вычисления значения функции y = f(a)
//  6. Выяснить является ли число чётным
//  7. Показать числа от -N до N
//  8. Показать четные числа от 1 до N
//  9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет

using static System.Console;


//  0. Вывести квадрат числа
// -------------------------------------
// WriteLine("Введите число");
// int number = int.Parse(ReadLine());

// WriteLine(number*number);
// -----------------------------

// int number = new Random().Next(1, 10000);
// WriteLine(number);
// WriteLine(number*number);


// --------------

// int number = new Random().Next(1, 100);
// WriteLine(number);

// int x = Square(number);
// int Square(int numb)
// {
//     return number * number;
// }
// WriteLine(x);



//  1. По двум заданным числам проверять является ли первое квадратом второго

// int a = new Random().Next(-100, 100);
// int b = new Random().Next(-100, 100);

// SQUARE(a, b);
// void SQUARE(int x, int y)
// {
//     if (x == y * y)
//         WriteLine($"Первое число {x} является квадратом второго {y}");
//     else
//         WriteLine($"Первое число {x} НЕ является квадратом второго {y}");
// }


//  2. Даны два числа. Показать большее и меньшее число

// int x = new Random().Next(1,100);
// int y = new Random().Next(1,100);

// Max_Min(x, y);

// void Max_Min(int a, int b)
// {
// if (a > b)
//     WriteLine($"{a} большее число, {b} меньшее число");
// else
//     WriteLine($"{b} большее число, {a} меньшее число");
// }


//  3. По заданному номеру дня недели вывести его название

// int day = new Random().Next(1, 8);

// Day_of_Week(day);

// void Day_of_Week (int n)
// {
//     if (n == 1)
//         WriteLine($"{day} - It's Monday");
//     else if (n == 2)
//         WriteLine($"{day} - It's Tuesday");
//     else if (n == 3)
//         WriteLine($"{day} - It's Wednesday");
//     else if (n == 4)
//         WriteLine($"{day} - It's Thursday");
//     else if (n == 5)
//         WriteLine($"{day} - TGIF");
//     else if (n == 6)
//         WriteLine($"{day} - It's Saturday");
//     else if (n == 7)
//         WriteLine($"{day} - It's Sunday");
// }


//  4. Найти максимальное из трех чисел

// int x = new Random().Next(-100, 100);
// int y = new Random().Next(-100, 100);
// int z = new Random().Next(-100, 100);

// int max = Max_Number(x, y, z);
// int Max_Number(int a, int b, int c)
// {
//     if (a > b && a > c)
//         return (a);
//     else if (b > a && b > c)
//         return (b);
//     else
//         return (c);
// }
// WriteLine($"between {x}, {y} and {z} max is {max}");

// 5. Написать программу вычисления значения функции y = f(a) y = sin(a)

// int sum = 180;
// int a = new Random().Next(0, 91);
// int b = new Random().Next(0, 91);
// int c = sum - a - b;

// double sin_a = Sinus(a, c);
// double sin_b = Sinus(b, c);
// double Sinus(int x, int y)
// {
//     return x/y;
// }
// WriteLine($"{a} - угол А; {b} - угол B; {c} - угол С; {sin_a} - sinus_A, {sin_b} - sinus_B");


//  6. Выяснить является ли число чётным

// int number = new Random().Next(-100, 100);
// WriteLine(number);
// Even(number);
// bool Even(int n)
// {
//     if (n % 2 == 0)
//         return true;
//     else
//         return false;
// }


//  7. Показать числа от -N до N

// int a = new Random().Next(-100,0);
// int b = new Random().Next(0, 100);

// WriteLine(a);
// WriteLine(b);

// string Print (int x, int y)
// {
//     string result = string.Empty;
//     for (int i = x; i <= y; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }
// WriteLine(Print(a,b));



//  8. Показать четные числа от 1 до N

// int N = new Random().Next(2, 100);
// WriteLine(N);

// string Even(int number)
// {
//     string result = string.Empty;
//         for(int i = 2; i <= number; i++)
//         {
//             if (i%2 == 0)
//             {
//                 result += $"{i} ";
//             }
//         }
//     return result;
// }
// WriteLine(Even(N));



//  9. Показать последнюю цифру трёхзначного числа

// int number = new Random().Next(-999, 999);
// WriteLine(number);

// int Last_Digit(int n)
// {
//     if (n < 0)
//         n *= -1;
//     return n%10;
// }
// WriteLine(Last_Digit(number));



// 10. Показать вторую цифру трёхзначного числа

// int number = new Random().Next(-999, 1000);
// WriteLine(number);

// int Second_Last_Digit(int n)
// {
//     if (n < 0)
//         n *= -1;
//     return(n/10%10);
// }
// WriteLine(Second_Last_Digit(number));

// ____________________________________________
// WriteLine("Введите число");
// int number = int.Parse(ReadLine());
// number = number / 100 % 10;
// if (number > 0)
//     WriteLine(number);
// else
//     WriteLine("Третье число отсутствует");

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// int number = new Random().Next(11, 100);
// WriteLine(number);
// int Max(int n)
// {
//     int last_number = n % 10;
//     int first_number = n / 10;
//     if (last_number > first_number)
//         return(last_number);
//     else
//         return(first_number);
// }
// WriteLine(Max(number));


// 12. Удалить вторую цифру трёхзначного числа

// int number = new Random().Next(-999, 1000);
// WriteLine(number);

// string Delete_Second_Digit (int n)
// {
//     if (n < 0)
//         n *= -1;
//     return $"{n/100}{n%10}";
// }
// WriteLine(Delete_Second_Digit(number));



// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// int number = new Random().Next(10, 1000);
// int del = new Random().Next(1, 10);
// WriteLine($"{number} {del}");
// int Remainder (int n, int d)
// {
//     if (n % d != 0)
//         return n%d;
//     return(-1);
// }
// WriteLine(Remainder(number, del));


// 14. Найти третью цифру числа или сообщить, что её нет
//-----------------------first version----------------------------------------------
// WriteLine("Введите число");
// int number = int.Parse(ReadLine());

// Third_Digit(number);
// void Third_Digit(int n)
// {
// if (n < 0)
//     n *= -1;

// int d_number = n;        
// int i = 0;

// while (d_number > 0)
// {
//     d_number/=10;        
//     i++;        // сколько разрядов
// }
// if (i > 2)   //в числе > 2 разрядов
// {
//     int j = 0;
//     while (j < i - 3)     //делим столько раз, пока не дойдем до 3 с конца цифры
//     {
//         n /= 10;
//         j++;
//     }
//     n %= 10;
//     if (n > 0)
//         WriteLine(n);
//     else
//     {
//         n *= -1;
//         WriteLine(number);
//     }

// }
// else        // в чсиле меньше 2 разрядов
//     WriteLine("третья цифра отсутствует");
// }

//-----------------------second version----------------------------------------------

// int number = new Random().Next(-10000, 10000);
// WriteLine(number);

// int ThirdDigit(int n)
// {
//     if (n < 0)
//         n *= -1;
//     if (n < 100)
//         return -1;
//     return n/100%10;
// }
// WriteLine(ThirdDigit(number));
