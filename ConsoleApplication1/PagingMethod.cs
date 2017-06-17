using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public  class PagingMethod
    {

        public string[] GetPagesv3(int count, int current)
        {
            //Вначале проверяем на нестандартные ситуации
            int mycounter = 1;
            List<string> paginationList = new List<string>();
            if (count < current || count < 1)
            {
                return new String[] { "0" };
            }
            if (count<3)
            {
                for (int i = 1; i < count+1; i++)
                {
                    paginationList.Add(i.ToString());
                }
                return paginationList.ToArray();
            }

            
            if (current>5|| current<3) // не входит в первый раздел
            {
                for (int i = 1; i < 4; i++)
                {
                    paginationList.Add(i.ToString());
                    mycounter++;
                }
                paginationList.Add("...");
            }
            else //входит
            {
                if (current>=3)
                {
                    for (int i = mycounter; i <= current+1; i++)
                    {
                        paginationList.Add(i.ToString());
                        mycounter++;
                    }
                }
                else
                {
                    for (int i = mycounter; i < current + 1; i++)
                    {
                        paginationList.Add(i.ToString());
                        mycounter++;
                    }
                }
            
            }
            if (mycounter+1<current) //проверяем троеточие 
            {

                if ("..."!=paginationList[mycounter-1])
                {
                    paginationList.Add("...");
                }


                if (current<count-3)
                {
                    for (int i = current - 1; i < current + 2; i++)
                    {
                        paginationList.Add(i.ToString());
                        mycounter++;
                    }
                }
               
            }
            else if(mycounter>4 && current < count - 4 || current >4 && current<count-4)
            {
                for (int i = mycounter; i < current+1; i++)
                {
                    paginationList.Add(i.ToString());
                    mycounter++;
                }
            }
            if (mycounter+2<count)
            {
                if (paginationList.Count>2 && mycounter <= count )
                {
                    if ("..." != paginationList[paginationList.Count-1 ] )
                    {
                        paginationList.Add("...");
                    }
                }

                for (int i = count - 2; i < count + 1; i++)
                {
                    paginationList.Add(i.ToString());
                    mycounter++;
                }
            }
            else if(mycounter>4 || current>4)
            {
                for (int i = mycounter; i < count + 1; i++)
                {
                    paginationList.Add(i.ToString());
                    mycounter++;
                }
            }
            if (!paginationList.Contains(count.ToString()))
            {
                for (int i = mycounter; i < count+1; i++)
                {
                    paginationList.Add(i.ToString());
                }
            }
            return paginationList.ToArray();
            
/*
                    if (current+2<count-3)
                    {
                        for (int i = 1; i < 4; i++)
                        {
                            paginationList.Add(i.ToString());
                        }
                        paginationList.Add("...");
                        for (int i = current - 1; i < count + 1; i++)
                        {
                            paginationList.Add(i.ToString());
                        }
                    }
                    else // если не входит печатаем все 3 отдельно
                    {
                        for (int i = 1; i < 4; i++)
                        {
                            paginationList.Add(i.ToString());
                        }
                        paginationList.Add("...");
                        for (int i = current - 1; i < current+2; i++)
                        {
                            paginationList.Add(i.ToString());
                        }
                        paginationList.Add("...");
                        for (int i = count-2; i < count + 1; i++)
                        {
                            paginationList.Add(i.ToString());
                        }
                    return paginationList.ToArray();
                }
                   
                


                



                for (int i = 1; i < current + 2; i++)   // печатаем первые цыферки
                {
                    paginationList.Add(i.ToString());
                    mycounter++;
                }
                if (current+1 < count - 4)
                    // проверяем входит ли в 1/2 интервал 3 интервал, если да печатаем вместе, если нет, раздельно
                {
                    for (int i = current + 1; i < count + 1; i++)
                    {
                        paginationList.Add(i.ToString());
                        mycounter++;
                    }
                }
                else
                {
                    if ((mycounter+2<count-2))//проверяем нужно ли ...
                    {
                        paginationList.Add("...");
                    }
                    else
                    {
                        for (int i = mycounter; i < count+1; i++)
                        {
                            paginationList.Add(i.ToString());
                            mycounter++;
                        }
                        return paginationList.ToArray();
                    }

                    for (int i = count - 2; i < count + 1; i++)
                    {
                        paginationList.Add(i.ToString());
                        mycounter++;
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

            return paginationList.ToArray();*/
        }
    }
}
