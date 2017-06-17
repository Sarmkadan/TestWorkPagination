using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaging   
{
    class Program   
    {
        static void Main(string[] args)
        {
            /*var a =   Power(5, 5);
              Console.WriteLine(a);
              Console.Read();*/
            /*  var a =  GetPages(100, 100);
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + ";");
                }
                Console.WriteLine();
                a = GetPages(11, 6);
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + ";");
                }
                Console.WriteLine();
    
                 a = GetPages(9, 5);
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + ";");
                }
                Console.WriteLine();
    
                a = GetPages(11, 5);
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + ";");
                }*/
            List<int> mylista = new List<int>() { 0, 1, 6, 7, 7, 7, 100, 100, 100, 11, 9, 11, 11 };
            List<int> myListb = new List<int>() { 0, 1, 3, 2, 3, 4, 50, 1, 100, 6, 5, 5, 4 };


            for (int q = 0; q < mylista.Count; q++)
            {
                var a = GetPagesv3(mylista[q], myListb[q]);
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + ";");
                }
                Console.WriteLine();
            }

            /* for (int q = 0; q < 2; q++)
             {
                 var a = GetPages(7, 4);
                 for (int i = 0; i < a.Length; i++)
                 {
                     Console.Write(a[i] + ";");
                 }
                 Console.WriteLine();
                 }*/
            Console.ReadLine();
        }

        public static string[] GetPagesv3(int count, int current)
        {
            int mycounter = 1;
            if (count < current || count < 1)
            {
                return new String[] { "0" };
            }
            List<string> paginationList = new List<string>();

            if (count <= 7 && current != 2)
            {
                for (int i = 1; i < count + 1; i++)
                {
                    paginationList.Add(i.ToString());
                }
                return paginationList.ToArray();
            }



            if (current < 6)  //входит ли первое число в интервал, если да - то печатаем до интервала +1
            {
                for (int i = 1; i < current + 1; i++)
                {
                    paginationList.Add(i.ToString());
                    mycounter++;
                }
            }

            else // если нет печатаем отдельно
            {
                for (int i = 1; i < 4; i++)
                {
                    paginationList.Add(i.ToString());
                    mycounter++;
                }
            }


            if (current <= count - 4 && mycounter + 2 > count - 3 && current > 6) //Проверяем входит ли среднее число в интервал 3 
            {
                paginationList.Add("...");
                for (int i = current - 1; i < count + 1; i++)
                {
                    paginationList.Add(i.ToString());
                    mycounter++;
                }

            }
            else if (mycounter < current) //если нет печатаем второй интвервал с -1 и +1 и 3 так же
            {
                paginationList.Add("...");
                for (int i = current - 2; i < current + 1; i++)
                {
                    paginationList.Add(i.ToString());
                }
                paginationList.Add("...");
                for (int i = count - 2; i < count + 1; i++)
                {
                    paginationList.Add(i.ToString());
                }
            }
            return paginationList.ToArray();
        }

        public static int Power(int x, uint n)
        {
            if (n == 0) return 1;
            var result = Power(x, n / 2);
            result *= result;
            if (n % 2 != 0)
                return result * x;
            return result;
        }

        private static string[] GetPagess(int count, int current)
        {
            //исключения
            if (count < current || count < 1)
            {
                return new String[] { "" };
            }
            int mycounter = 1;
            if (count < 4)
            {
                List<string> myList = new List<string>();
                for (int i = 1; i < count; i++)
                {
                    mycounter++;
                    myList.Add(i.ToString());
                }
                return myList.ToArray();
            }
            else
            {
                List<string> myList = new List<string>();
                for (int i = 1; i < 4; i++)
                {
                    mycounter++;
                    myList.Add(i.ToString());
                }
                if (current >= 6)
                {
                    myList.Add("...");
                    for (int i = mycounter; i < current + 1; i++)
                    {
                        myList.Add(i.ToString());
                    }
                }
                else
                {
                    for (int i = current; i < current + 3; i++)
                    {
                        myList.Add(i.ToString());
                    }
                }

                return myList.ToArray();
            }
        }

        private static string[] GetPages(int count, int current)
        {
            int mycounter = 1;
            //исключения из правил
            if (count < current || count < 1)
            {
                return new String[] { "" };
            }
            if (count <= 6 && count >= 1)
            {
                string[] pagingList = new String[count + 1];
                for (int i = 1; i < count + 1; i++)
                {
                    mycounter++;
                    pagingList[i] = i.ToString();
                }
                return pagingList;
            }
            /*    if (count<4)
                {
                    string[] pagingList = new String[count+1];
                    for (int i = 1; i < count; i++)
                    {
                        pagingList[0] = i.ToString();
                    }
                    return pagingList;
                }*/
            //формируем масив
            List<string> paginationList = new List<string>();

            //проверяем не включаеться ли наш текущий елемент в певые елементы
            if (current > 4 && count > 4 && current <= 6)
            {
                paginationList.Add("1");
                paginationList.Add("2");
                paginationList.Add("3");
                mycounter = 3;
            }
            else
            {
                for (int i = 1; i < 4; i++)
                {
                    paginationList.Add(i.ToString());
                    mycounter++;
                }
                ;
            }
            // пробел если курент больше следующих чисел и не включен в превидущие
            if (current > 5)
            {
                paginationList.Add("...");
            }
            else if (current > 4)
            {
                for (int i = current - 1; i < current + 2; i++)
                {
                    paginationList.Add(i.ToString());
                    mycounter++;
                }
            }
            // проверяем или куррент не входит в последний раздел
            if (current < count && current > count - 3 && mycounter >= current)
            {
                for (int i = mycounter; i < count - 3; i++)
                {
                    paginationList.Add(i.ToString());
                    mycounter++;
                }
                paginationList.Add("...");
                for (int i = mycounter; i < count + 1; i++)
                {
                    paginationList.Add(i.ToString());
                    mycounter++;
                }
            }
            else
            {
                if (current > 5 && current + 2 < count)
                {
                    for (int i = current - 1; i < current + 2; i++)
                    {
                        paginationList.Add(i.ToString());
                        mycounter++;
                    }
                }
                if (count > current + 4)
                {
                    paginationList.Add("...");
                    for (int i = count - 2; i < count + 1; i++)
                    {
                        paginationList.Add(i.ToString());
                        mycounter++;
                    }
                    return paginationList.ToArray();
                }
                if (current <= count && current >= count - 3)
                {
                    for (int i = current; i < count + 1; i++)
                    {
                        paginationList.Add(i.ToString());
                        mycounter++;
                    }
                    return paginationList.ToArray();
                }

                for (int i = mycounter + 1; i < count + 1; i++)
                {
                    paginationList.Add(i.ToString());
                }
            }
            return paginationList.ToArray();
        }
    }
}
