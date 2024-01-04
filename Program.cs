// Задача 1: Задайте значения M и N. Напишите программу,которая выведет 
// все натуральные числа в промежутке от M до N. 
//  Использовать рекурсию, не использовать циклы.
// Пример:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// int num1 = new Random().Next(1,10);
// int num2 = new Random().Next(1,10);

// System.Console.WriteLine("Наше число " + num1);
// System.Console.WriteLine("Наше число " + num2);

// if (num1 <= num2)
// {
//     int M = num1;
//     int N = num2;

//     PrintNumbers(M,N);

//     void PrintNumbers(int startEl, int endEl)
//     {
//         System.Console.WriteLine(startEl);

//         if(startEl ==endEl)
//         {
//             return;
//         }

//         PrintNumbers(startEl +1,endEl);

//     }
    
// }

// else
// {
//     int T = num2;
//     int D = num1;

//     PrintNumbers2(T,D);

//     void PrintNumbers2(int startEl2, int endEl2)
//     {
//         System.Console.WriteLine(startEl2);

//         if (startEl2 ==endEl2)
//         {
//             return;
//         }

//         PrintNumbers2(startEl2 +1,endEl2);
  
//     }

// }    



// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// Пример:
// m = 1, n = 3 -> A(m,n) = 5

// Console.WriteLine("Введите неотрицательное число m");
// int m =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите неотрицательное число n");
// int n =Convert.ToInt32(Console.ReadLine());

// int Akkerman(int m,int n)
// {
//     if (m ==0)
//     {
//         return n+1;
//     }
//     else
//     {
//         if (n ==0)
//         {
//             return Akkerman(m-1,1);
//         }
//         else
//         {
//             return Akkerman(m-1,Akkerman(m,n-1));
//         }
//     }
// }
// Console.WriteLine(Akkerman(m,n));



// Задача 3: Задайте произвольный массив. Выведете его элементы,
// начиная с конца. Использовать рекурсию, не использовать циклы.
// Пример:
// [1,2,5,0,10,34] => 34 10 0 5 2 1

// int[] array = new int[]{5,7,3,55,8};
// System.Console.WriteLine(String.Join(" ",array));

// string str = " ";
// int i =array.Length-1;

// System.Console.WriteLine(GetStringFromArray(str));

// string GetStringFromArray(string newStr)
// {
    
//     if (i >=0)
//     {
//         newStr =str+" "+ array[i];
//         i=i-1;
//         return newStr +GetStringFromArray(newStr);

//     }
    
//     return(str);

// }







