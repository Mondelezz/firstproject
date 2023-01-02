using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Reference
{
    public class AddValueInArray
    {
        public static void Boor()
        {

            Random random= new Random();
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(10);
            }

            static void SomeMetod(int[] result1)
            {
                for (int i = 0; i < result1.Length; i++)
                {
                    Console.Write(result1[i] + " ");
                }
            }

            static int[] AppendToStart(ref int[] array, int value)
            {
                int[] result = new int[array.Length + 1];
                result[0] = value;
                for (int i = 0; i < array.Length; i++)
                {
                    result[i + 1] = array[i];
                }
                return result;
                
            }

            static int[] AppendToEnd(ref int[] array, int value)
            {
                int[] result = new int[array.Length + 1];
                result[array.Length] = value;
                for (int i = 0; i < array.Length; i++)
                {
                    result[i] = array[i];
                }
                return result;
              
            }

            static int[] AppendToSelect(ref int[] array, int value, int index)
            {
                int[] new_array = new int[array.Length + 1];
                new_array[index] = value;
                for (int i = 0; i < index; i++)
                {
                    new_array[i] = array[i];
                }
                for (int i = index; i < array.Length; i++)
                {
                    new_array[i + 1] = array[i];
                }
                return new_array;
                
            }
            
            Console.WriteLine("Нажмите 1, чтобы добавить элемент в начало массива \n" +
                "Нажмите 2, чтобы добавить элемент в конец массива \n" + "Нажмите 3, чтобы добавить элемент в любое место массива \n ");

            
            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        {
                            int[] i = AppendToStart(ref array, 9);
                            SomeMetod(i);
                        }
                        break;
                    case 2:
                        {
                            int[] i = AppendToEnd(ref array, 17);
                            SomeMetod(i);
                        }
                        break;
                    case 3:
                        {
                            int[] i = AppendToSelect(ref array, 9999, 4);
                            SomeMetod(i);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Такой команды не существует!\nПовторите попытку");
                        }
                        break;
                }
            }
            
        }
    }
    
}
