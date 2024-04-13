namespace function1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 함수를 왜 쓰는가?

            //Console.WriteLine . 콘솔 창에 텍스트를 출력하는 무언가.
            // 함수. 반복적인 실행을 줄이기 위해 사용
            // 결과 값을 변환할 수도 있고, 안할 수도 있음.

            int a = 10;
            int b = 20;

            void Start() { }
            void Update() { }
            
            
            
            
            Console.WriteLine("Hello, World!");

            int result = Add2(a, b);
            
            Add(10, 20);
            
            //Boolean 타입
            
            bool isBoy = true;
            Console.WriteLine(isBoy);
            
            
            //동전의 앞면은 1, 뒷면 0
            
            string myString = Console.ReadLine();
            Console.WriteLine(myString);
            int coinNumer = int.Parse(Console.ReadLine()); //1이 int1로 전환
            
            // 주석: 코드는 사람이 보는 것이기 때문에 설명을 달아둘 수 있다.
            // 컴퓨터는 인식X
            
            // ctrl + k + c : 일괄 주석 처리
            // ctrl + k + u : 일괄 주석 해제
            // alt 누른 상태로 마우스 커서: 이동 일괄 처리 가능
            // 이동 하고 싶은 코드를 드레그 한 후 alt를 누른 상태로 키보드 화살표 위 아래 사용
            
            if (coinNumer == 1)
            {
                Console.WriteLine("왼손으로 휘두른다");
            }
            else if(coinNumer == 0)
            {
                Console.WriteLine("오른손으로 휘두른다");
            }

            // 두 수를 비교

            bool isFrontValueBiggerThanBehind = 10 > 25; // False
            bool isSame = 10 == 10; // True
            bool isSameAndBigger = 10 >= 15; // False
            // bool 데이터 자료형 앞에 !는 not의 의미

            //Quiz?? 다음 결과 값의 결과는?
            var number = 100;
            var resultB = !(number < 20); //Not False = True

            //Quiz??? a와 b를 더한 결과가 n보다 크거나 같은지 리턴하는 함수 만들기
            Console.WriteLine("불 확인 함수의 결과 값" + BooleanTypeAndOperator(3, 5, 7)
        }

        static void Add(int a, int b) // 결과 값을 변환하지 않음
        {

            int sum = a + b;
            Console.WriteLine(sum);
        }

        static int Add2(int a, int b)
        {
            int sum = a + b;
            return sum;

            // 함수의 문법

            // 반환 값 함수의 이름()
            // {
            //      코드 블럭
            //      실제로 코드를 처리하는 부분을 코드 블럭이라 한다. { 열렸으면 } 닫혀야 함. 아니면 EOF 에러뜸.
            // }

            // 반환 값....
            // 함수를 실행하고 나서 결과 값을 변환해주고 싶으면, void 대신 반환하고 싶은 데이터 타입(자료형)을 적어주면 된다.
            // 반환 값이 있는 함수는 반드시 해당 데이터를 return 해줘야 한다.

            void BooleanTypeAndOperator(int a, int b, int n)
            {
                //두 수를 더한 값이 n 보다 크거나 같으면 True를 리턴
                //아니면 False를 리턴하도록 만드는 함수
                if (a + b >= n)
                {
                    return true;
                }
                else if (a + b < n)
                {
                    return false;
                }
                bool AnyBool = true;
                return AnyBool;

                //Quiz??? a와 b를 더한 결과가 n보다 크거나 같은지 리턴하는 함수 만들기
                Console.WriteLine("불 확인 함수의 결과 값" + BooleanTypeAndOperator(3, 5, 7));
            }


        }




    } 

}