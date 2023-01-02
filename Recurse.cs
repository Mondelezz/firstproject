using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference
{
    class Recurse
    {
       
        private int age = 0;

        public int MyProperty
        {
            get 
            {
                return age;
            }
            set 
            {
                if ( value< 1 || value > 120)
                {
                    Console.WriteLine("Введенное значениe должно быть от 1 до 120");
                }
                else
                {
                    age = value;
                    Console.WriteLine(age);
                }
            }
        }

        public string Name { get; } = "Pankov Egor Sergeevich";


        public static void PArametrs(int a, int b,bool enableLogging = false, params float[] parametrs )
        {
            for (int i = 0;  i < parametrs.Length;  i++)
            {
                Console.WriteLine(parametrs[i]);
            }
            if (enableLogging)
            {
                Console.WriteLine("fofofofo");
            }
        }

    }
}
