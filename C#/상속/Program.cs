namespace 상속
{

    //상속
    //기존 클래스의 속성과 기능을 자식한테 물려주는 문법
    //case1. 클래스에서도 반복적으로 선언되는 경우가 빈번.
    //case2. 상속 문법 사용
    //case3. 상속의 생성자
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank myBank = new Bank("농협", 10000); //모든 은행이 공통적으로 갖는 기능과 속성을 기술
            myBank.Show();
            CenterBank centerBank = new CenterBank("중앙은행", "부모", 10000, 0); //중앙은행만 갖는 기능과 속성을 기술

            centerBank.Show();
            Console.WriteLine($"bank의 데이터 ");




            object obj = new object();


            //개발중에 중앙은행에서 오류 발생 >centerBank
            //전체 은행에서 에러 발생 >Bank
        }






    }
}