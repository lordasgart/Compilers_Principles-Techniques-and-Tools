using System;

namespace Fig113a
{
    class Original
    {
        public void RunExample()
        {
            int w, x, y, z;
            int i = 4; int j = 5;
            {
                int j = 7;
                i = 6;
                w = i + j;
            }
            x = i + j;
            {
                int i = 8;
                y = i + j;
            }
            z = i + j;

            Console.WriteLine("{0} {1} {2} {3}", w, x, y, z);
        }
    }
}
