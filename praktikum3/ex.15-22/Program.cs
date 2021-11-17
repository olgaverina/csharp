
// Почувствуй себя джуном
// 15. Дано число. Проверить кратно ли оно 7 и 23
// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
// 17. По двум заданным числам проверять является ли одно квадратом другого
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y           
// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Задать номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D


using static System.Console;



//15. Дано число. Проверить кратно ли оно 7 и 23

// WriteLine("Введите число");
// int number = int.Parse(ReadLine());

// if (number % 23 == 0 && number % 7 == 0)
//     WriteLine("Проверили: кратно");
// else
//     WriteLine("не кратно");


//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

// WriteLine("Введите число");
// int number = int.Parse(ReadLine());

// WriteLine("Введите числовое обозначение первого выходного от 1 до 7");
// int Saturday = int.Parse(ReadLine());

// WriteLine("Введите числовое обозначение второго выходного от 1 до 7");
// int Sunday = int.Parse(ReadLine());

// int number = new Random().Next(1, 7);
// WriteLine($"\nЧисло, сгенерированное рандомом - {number}  \n");

// if (number == Saturday || number == Sunday)
//     WriteLine("Выходной");
// else
//     WriteLine("Не выходной");


// 17. По двум заданным числам проверять является ли одно квадратом другого

// WriteLine("Введите число");
// int a = int.Parse(ReadLine());

// WriteLine("Введите второе число");
// int b = int.Parse(ReadLine());

// bool Square(int x, int y)
// {
//     return (x * x == y || y * y == x);
// }
// WriteLine(Square(a, b));



// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y     

// bool Check(bool x, bool y)
// {
//     return (!(x || y) == (!x && !y));
// }

// bool abs = Check(true, true);
// WriteLine(Check(5, 25));
// bool abs = Check(true, false);
// WriteLine(Check(5, 25));
// bool abs = Check(false, false);
// WriteLine(Check(5, 25));
// bool abs = Check(false, true);
// WriteLine(Check(5, 25));


// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

// int x = new Random().Next(-100, 100);
// int y = new Random().Next(-100, 100);
// Console.WriteLine($"{x}, {y}");
// int Check (int a, int b)
// {
//     if (a > 0 && b > 0)
//         return (1);
//     if (a < 0 && b > 0)
//         return (2);
//     if (a < 0 && b < 0)
//         return (3);
//     if (a > 0 && b < 0)
//         return (4);
//     return(0);     // если Х или У равны 0, то выводит 0, нулевой четверти не существует
// }
// WriteLine(Check(x, y));



// 20. Задать номер четверти, показать диапазоны для возможных координат

// int x = new Random().Next(1, 5);
// Console.WriteLine(x);

// string Check(int a)
// {
//     if (a == 1)                     //(a > 0 && b > 0)
//         return "диапазон x и y от 0 до + бесконечности";
//     else if (a == 2)                     //(a < 0 && b > 0)
//         return "диапазон x от 0 до - бесконечности и y от 0 до + бесконечности" ;
//     else if (a == 3)                      //(a < 0 && b < 0)
//         return "диапазон x от 0 до - бесконечности и y от 0 до - бесконечности";
//     else if (a == 4)                         //(a > 0 && b < 0)
//         return "диапазон x от 0 до + бесконечности и y от 0 до - бесконечности";
//     return "";
// }

// WriteLine(Check(x));


// 21. Программа проверяет пятизначное число на палиндромом.

// int number = 14341;

// int Palindr(int x)
// { 
//     if ((number/10000 == number%10) && (number / 1000 % 10 == number / 10 % 10))
//         return 1; //succes
//     return -1;  //fail
// }
// WriteLine(Palindr(number));



// 22. Найти расстояние между точками в пространстве 2D/3D

// int x1 = -1;
// int y1 = 1;
// int x2 = 1;
// int y2 = -1;

// double Distance(int a1, int a2, int b1, int b2)
// {
//     double katet1 = a1 - a2;
//     double katet2 = b1 - b2;

//     double gipoten = Math.Sqrt(katet1 * katet1 + katet2 * katet2);
//     return (gipoten);
// }
// WriteLine(Distance(x1, x2, y1, y2));

