namespace Reference
{
    public class StaticMethod
    {
        public static void TestStaticMethod()
        {
            Console.WriteLine("Введите Ваш возраст! ");
          
            
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                throw new ClassException("Error");
            }

            StaticMethod staticMethod = new StaticMethod(age);

            StaticMethod.YearsBeforeDeath(age);
        }
        private static int retirementAge = 65 + DateTime.Now.Year - 2022;
        public static int RetirementAge
        {
            set 
            {
                if (value < retirementAge)
                {
                    Console.WriteLine($"До пенсии Вам осталось:  {retirementAge - value}");
                }
                else
                {
                    Console.WriteLine("Вы уже на пенсии! ");
                }
                retirementAge -=  value; 
            }
            get
            { 
                return retirementAge; 
            }
        }
        static StaticMethod()
        {
            if (DateTime.Now.Year == 2022)
            {
                Console.WriteLine($"Текущий пенсионный возраст  {retirementAge - DateTime.Now.Year - 2022}");
            }
            else
            {
                Console.WriteLine($"Текущий пенсионный возраст  {retirementAge}");
            }
        }
        public StaticMethod(int age)
        {
            Console.WriteLine($"Ваш возраст: {age}");
            RetirementAge = age;
        }

        public static void YearsBeforeDeath(int age)
        {
            
            if (age >= retirementAge)
            {
                Console.WriteLine("Вам осталось жить меньше 100 лет ");
            }
            else
            {
                Console.WriteLine("Вся жизнь ещё впереди С:");
            }
        }

    }

    public class ClassException : Exception
    {
        public ClassException(string text)
            : base(text)
        {
        }
    }
}
