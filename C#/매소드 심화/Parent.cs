using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 매소드_심화
{
    //ctrl R R 참조되어있는 모든 이름 바꾸기
    internal class Parent
    {
        //virtual : 지금 클래스가 자신의 클래스가 아니라면 (자식이라면) 자식의 함수를 실행해라 
        public void Method1() 
        {
            Console.WriteLine("Parent의 Method1");
        }

        public virtual void Method2() 
        {
            Console.WriteLine("Parent의 Method2");
        }

        //함수의 사용 방법. return이 있으면 반환 값에 해당하는 데이터, 없으면 void
        //두개 이상 반환 값 리턴 : ref, out


        //ref 사용 전에 변수 미리 선언
        int shareNumber = 0; // 몫 저장
        int remainNumber = 0; // 나머지 저장

        //reference(참조) : 매개 변수로 넘겨준 데이터를 참조해서 저장해두었다가 반환 2개 이상의 데이터를 반환 할 수 있게 됨.
        public void Divide(int first, int second, ref int shareNumber, ref int remainNumber)
        {
            first = 3;
            second = 2;

            shareNumber = first / second; // 3 / 2 = 1
            remainNumber = (first % shareNumber); // 수에서 몫을 뺀 값 = 나머지 

            // return 1개의 데이터만 반환
        }

        //out 키워드는 ref 키워드와 역할이 완벽하게 똑같지만 약간 다름
        // out 키워드로 선언한 변수를 바꾸지 않고 있다
        // out 키워드로 선언한 변수는 내부에서 무조건 사용되기 때문에, 함수가 선언 될 때 변수를 초기화 할 수 있다는 장점
        public void Divide2(int first, int second, out int shareNumber, out int remainNumber)
        {
            first = 3;
            second = 2;

            shareNumber = first / second; // 3 / 2 = 1
            remainNumber = (first % shareNumber); // 수에서 몫을 뺀 값 = 나머지 

            // return 1개의 데이터만 반환
        }
    }


    class Child : Parent
    {
        //내부적 base의 void Method1()을 포함하고 있기 때문에 구별 필요
        //변수는 base, this 키워드로 구별

        //new 키워드: 클래스 선언의 new와 다름


        public new void Method1()   //new를 통해 Child만 접근 가능
        {
            Console.WriteLine("Child의 Method1");
        }

        //override 부모의 함수 중에서 virtual 명시된 녀석이 있으면 이 키워드가 선언된 함수를 실행
        //override 하고 나서, 부모에 같은 함수가 없으면 error를 띄워줌
        public override void Method2() 
        {
            Console.WriteLine("Child의 Method2");
        }




    }



}
