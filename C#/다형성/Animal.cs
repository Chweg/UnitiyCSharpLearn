﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 다형성
{
    class Worker // 동물 케어 기능
    {
        public void CareAnimal(Animal animal) // 오버로딩으로 수많은 데이터 타입 선언 >> 너무 많음
        {
            // 동물을 돌봐준다
            animal.HP += 10;
        }
        
        public void Function(Animal animal)
        {
            // 동물은 각자 동물이면서, 호랑이 일 수도 있고, 상어 일 수도 있고, 독수리 일 수도 있음

            if( animal is Animal_Tiger)
            {
                Console.WriteLine("호랑이입니다");
            }
            else if( animal is Animal_Shark) 
            {
                Console.WriteLine("상어입니다");
            }
            else if( animal is Animal_Eagle) 
            {
                Console.WriteLine("독수리입니다");
            }
            else
            {
                Console.WriteLine("해당하는 동물이 없습니다");
            }

            //animal이 Animal_Tiger타입이면 해당 타입을 animal로 넣어주고,
            //아니라면 null로 넣어줌
            if(null == animal as Animal_Tiger)
            {
                Console.WriteLine("호랑이 타입이 아니기 때문에 코드를 확인해주세요");
            }
        }
     
    }

    internal class Animal
    {
        public int HP;
    }

    class Animal_Tiger : Animal
    {
        void Run() { }
    }

    class Animal_Shark : Animal
    {
        void Swim() { }
    }

    class Animal_Eagle : Animal
    {
        void Fly() { }
    }















}
