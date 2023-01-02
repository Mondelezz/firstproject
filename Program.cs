using Reference;
using System.Runtime.InteropServices;
using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Refernce
{
    enum DayOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    enum Color
    {
        Red,
        Yellow,
        Blue,
        Green,
        Orange,
    }
    class Point
    {
        public int x = 5;
        private int y = 55;

        public void PrintY()
        {
            Console.WriteLine($"Y {y}");
        }
        private void PrintX()
        {
            Console.WriteLine($"X {x}");
        }
        public void PrintPoint()
        {
            PrintX();
        }
    }
    class Program
    {
        
        static void MyArray(int[] array,int i = 0, int counter = 0)
        {
            if (i < array.Length)
            {
                Console.Write(array[i] + " ");
                counter += array[i];
                i++;
                MyArray(array, i, counter);
            }
            else
                Console.WriteLine("\n" + counter);


        }

        static void CounterValue(int value, int counter = 0)
        {
            if (value > 0)
            {
                counter += value % 10;
                value /= 10;
                CounterValue(value, counter);
            }
            else 
            { 
                Console.WriteLine("Сумма цифр чсила "+ counter);
            }
        }

        static void Float(float value, int a)
        {
            Console.WriteLine(value + a);
        }

        static void Overflow()
        {
            byte a = 14;
            byte b = 2;
            try
            {
                Console.WriteLine(checked((byte)(b - a)));
            }
            catch (Exception)
            {
                Console.WriteLine("Переполнение ");

            }
            int l = 32;
            Console.WriteLine(Convert.ToBoolean(l));
        }

        static void ReadKey()
        {
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key; // Использую пространство имён ConsoleKey и создаю объект key,
                                                        // Вызываю метод ReadKey() у класса Console, который возвразщает структуру ConsoleKeyInfo,
                                                        // где есть поле Key
                int keycode = (int)key;
                Console.WriteLine($"Enum {key}\tCode {keycode}");

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Вы нажали Enter");
                }
            }
                       
        }

        static void EnumDayOfWeek()
        {
            DayOfWeek day = DayOfWeek.Sunday;

            Console.WriteLine((int)day); // номер дня недели
            int value = 3;
            if (Enum.IsDefined(typeof(DayOfWeek), value))
            {
                day = (DayOfWeek)value;
            }
            else
            {
                throw new Exception("Invalid value in DayOfWeek! ");
            }
            Console.WriteLine(day); // день, под номером value
            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek))); // тип данных enum(a)
        }
        static Student GetStudent()
        {
            var student = new Student(FirstName: " Egor", MiddleName: "Sergeevich", LastName: "" +
                "Pankov", Group: 922);

            student.id = Guid.NewGuid();
            student.Age = 17;
            student.Group = 922;

            return student;

        }
        static void TestStudent()
        {
            Student student1 = new Student(FirstName: " Egor", MiddleName: "Sergeevich", LastName: "" +
                "Pankov", Group: 922);


            Console.WriteLine(" ");

            Student student2 = new Student(student1);
            student1.SetLastName("#######");
            student1.Print();

            student2.Print();
        }

        
        static void Main(string[] args)
        {

            StaticMethod.TestStaticMethod();



            //AddValueInArray.Boor();

            //Recurse.PArametrs(a: 5, b: 4, enableLogging: true, 4,3,2,1,1,1);
        }
    }
    
}
