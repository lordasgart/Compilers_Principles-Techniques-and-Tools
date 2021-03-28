using System;

namespace Fig113a
{
    class Test
    {
        public void RunExampleModified()
        {
            int w, x, y, z;
            int i = 4; int j = 5;
            {
                int j2 = 7;
                i = 6;
                w = i + j2;
            }
            x = i + j;
            {
                int i2 = 8;
                y = i2 + j;
            }
            z = i + j;

            Console.WriteLine("{0} {1} {2} {3}", w, x, y, z);
        }
    }
}
