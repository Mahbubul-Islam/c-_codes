
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    public class A
    {
        public int x;
        private int y;
        protected int z;
        internal int i;
        protected internal int j;
        public class C : B
        {
            public void M2()
            {
                x = 1;
                y = 2;
                z = 3;
                i = 4;
                j = 5;
                
            }
        }

    }

    public class B:A
    {
        internal int x1;
        public void M1()
        { 
            x1 = 1;
            x = 2;
            z = 3;
            i = 4;
            j = 5;
        }
    }
    internal class program
    {
        static void Main(string[] args)
        {
            

        }
    }
}

namespace N2
{
    public class D:B
    {
        private int x2;
        public virtual void M3() 
        { 
            x2 = 1;
        }
    }
    public class E : D
    {
        public override void M3()
        {
            
        }
        static void Main(string[] args) { }
    }

}
