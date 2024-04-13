using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    internal class Memory
    {
        public int value = 10;
        public string name = "홍길동";
        public int attack = 100;
        public float attackRange = 3.14f;

        public void AddValue(int value)
        {
            value = value + this.value;
        }

        public void SomeFunction(int value) 
        {
            this.value = 100;
        
        
        
        }
    }
}
