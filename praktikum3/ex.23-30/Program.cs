
// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 
// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А
// 26. Возведите число А в натуральную степень B используя цикл
// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру


using static System.Console;


//23. Показать таблицу квадратов чисел от 1 до N 
// int N = new Random().Next(1, 10);
// WriteLine(N);

// string Square(int x)
// {
//     string res = String.Empty;
//     for (int i = 1; i <= N; i++)
//     {
//         res += $"{i * i} ";
//     }
//     return res;

// }
// WriteLine(Square(N));

// 24. Найти кубы чисел от 1 до N

// int N = new Random().Next(1, 10);
// WriteLine(N);

// string Cube(int x)
// {
//     string res = String.Empty;
//     for (int i = 1; i <= N; i++)
//     {
//         res += $"{i * i * i} ";
//     }
//     return res;

// }
// WriteLine(Cube(N));


// 25. Найти сумму чисел от 1 до А

// double N = 1_000_000_000;// new Random().Next(1, 10);
// WriteLine(N);

// double Sum(double x)
// {
//     return x*(x+1)/2;
// }
// DateTime dt = DateTime.Now;
// WriteLine(Sum(N));
// Console.WriteLine((DateTime.Now-dt).TotalMilliseconds);


// 26. Возведите число А в натуральную степень B используя цикл

// int A = new Random().Next(1, 10);
// int B = new Random().Next(1, 10); 
// WriteLine(A);
// WriteLine(B);
// int Degree (int x, int y)
// {
//     int result = 1;
//     for(int i = 1; i <= y; i++)
//     {
//         result *= x;
//     }
//     return (result);
// }
// WriteLine(Degree(A, B));


// 27. Определить количество цифр в числе

// int number = -12345678;

// int Amount(int num)
// {
//     int i = 0;
//     if (num < 0)
//         num *= -1;
//     while (num > 0)
//     {
//         num /= 10;
//         i++;
//     }
//     return i;
// }
// WriteLine(Amount(number));



// 28. Подсчитать сумму цифр в числе

// int number = new Random().Next(-10000,10000);
// WriteLine(number);
// int Sum(int n)
// {
//     if (n < 0)
//         n *= -1;
//     int left = 0;
//     while (n > 0)
//     {
//         left += n%10;
//         n /= 10;
//     }
//     return (left);
// }
// WriteLine(Sum(number));

// 29. Написать программу вычисления произведения чисел от 1 до N

// int number = new Random().Next(1, 10);
// WriteLine(number);
// int Multipl(int num)
// {
//     int mult = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         mult *=i;
//     }
//     return (mult);
// }

// WriteLine(Multipl(number));


// 30. Показать кубы чисел, заканчивающихся на четную цифру

// int N  = 15; //new Random().Next(1, 100);
// WriteLine(N);

// string Cube(int n)
// {
//     string res = String.Empty;
//     for (int i = 1; i <= n; i++)
//     {
//         if (i*i*i % 2 == 0)
//             res += $"{i * i * i} ";
//     }
//     return res;
// }
// WriteLine(Cube(N));
