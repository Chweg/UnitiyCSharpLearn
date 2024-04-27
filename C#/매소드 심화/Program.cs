namespace 매소드_심화
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int shareNumber = 0;
            int remainNumber = 0;



            Parent parent = new Parent();
            parent.Method1();
            parent.Method2();
            parent.Divide(3, 2, ref shareNumber, ref remainNumber); //ref는 할당되지 않은 변수를 매개변수로 넘길 수 없지만 out은 매개변수에 선언하면서 넘겨줄 수 있음
            parent.Divide2(3, 2, out int s1, out int r1);

            Console.WriteLine($"나눈 결과 값 확인 : 몫 : {shareNumber} \n나머지 : {remainNumber}");

            Parent child = new Child();
            child.Method1();
            child.Method2();
        }
    }
}