using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상속
{
    internal class Bank
    {
        //접근 지정자를 통해서 외부에서 사용할 수 있는지 없는지 허락
        //private:나만
        //public:전부다
        //protect:내 상속까지만
        protected string name;
        protected int money;

        public void Withdarw() { }

        public void Deposit() { }

        public void Show()
        {
            Console.WriteLine($"Bank의 이름 : {name} \nBank의 금액 : {money}");
        }

        public Bank() { } //기본 생성자

        public Bank(string name, int money)
        {
            this.name = name;
            this.money = money;
        }
    }

    class CenterBank : Bank
    {
        //공통적인 요소 호출

        public string name;
        public int centerMoney;

        public void MakeMoney() { }

        //내부 변수를 콘솔창에 띄워줌
        public void Show()
        {
            base.name = "부모의 이름";       //base, this 키워드를 이용하여 구분
            this.name = "중앙 은행";
            money = 50000;
        }

        public CenterBank(string name, string parentName, int centerMoney, int money)
        {
            this.name = name;
            this.centerMoney = centerMoney;
        }
    }

    //중앙은행: 화폐를 만들 수 있음
    //지역은행: 돈을 입금, 인출







}

