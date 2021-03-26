using System;

namespace Fig113a
{
    class Fig113a
    {
        int w, x, y, z;
        int i = 4; int j = 5;

        public void Run()
        {
             Scope1();
             x = i + j;
             Scope2();
             z = i + j;

             Console.WriteLine("{0} {1} {2} {3}", w, x, y, z);
        }

        void Scope1()
        {
            int j = 7;
            i = 6;
            w = i + j;
        }

        void Scope2()
        {
            int i = 8;
            y = i + j;
        }
    }
}
