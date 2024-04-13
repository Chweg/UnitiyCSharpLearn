using System;

namespace unityCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 기본 자료형 (Primitive types): 정수형, 실수형, 문자형, boolean형
            // 변수의 선언
            int myInt;

            // 변수의 할당
            myInt = 10;

            // 실수형
            float myFloat = 3.14f;

            // 문자열
            string myString = "Hello, World!";


            int number1 = 10;
            int number2 = 20;

            int sum;
            sum = number1 + number2;
            string result = "두 수를 더한 값" + " ";
            Console.WriteLine(result + (number1 + number2));
            Console.WriteLine(result + number1 + number2);

            int sub;
            sub = number1 - number2;
            Console.WriteLine(sub);


            int multi;
            multi = number1 * number2;
            Console.WriteLine(multi);


            int divide;
            divide = number1 / number2;
            Console.WriteLine(divide);


            int a = 10;
            int b = 20;
            int c = 3;
            int resultA = (a + b) / c;
            Console.WriteLine(resultA);


        }
    }
}