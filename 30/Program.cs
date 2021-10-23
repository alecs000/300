using System;
using System.IO;
namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
            WTF wtf = new WTF(2, 3, 4);
            WTF wtf1 = new WTF(1, 3, 9);
            Console.WriteLine(wtf.Specifications());
            Console.WriteLine(wtf1.Specifications());

            //WTF wtf = new WTF(2, 3, 4);
            //string ss = wtf.Specifications();



            //using (StreamWriter sw = new StreamWriter(@"C:\Users\aafedotov\source\repos\30\30\t.txt", false, System.Text.Encoding.Default))
            //{
            //    sw.WriteLine(ss);

            //}
            //WTF wtf1 = new WTF(1, 3, 9);
            //string ss1 = wtf1.Specifications();


            //using (StreamWriter sw = new StreamWriter(@"C:\Users\aafedotov\source\repos\30\30\t.txt", true, System.Text.Encoding.Default))
            //{
            //    sw.WriteLine(ss1);

            //}
            if (wtf.Sqare() > wtf1.Sqare())
            {
                Console.WriteLine("Площадь 1 > 2");
            }
            else if(wtf.Sqare() < wtf1.Sqare())
            {
                Console.WriteLine("Площадь 1 < 2");
            }
            else if (wtf.Sqare() == wtf1.Sqare())
            {
                Console.WriteLine("Площадь 1 = 2");
            }
            if (wtf.Valume() > wtf1.Valume())
            {
                Console.WriteLine("ОБЬЁМ 1 > 2");
            }
            else if (wtf.Valume() < wtf1.Valume())
            {
                Console.WriteLine("ОБЬЁМ 1 < 2");
            }
            else if (wtf.Valume() == wtf1.Valume())
            {
                Console.WriteLine("ОБЬЁМ 1 = 2");
            }
            Console.WriteLine("Длинна массива: ");
            int num = int.Parse(Console.ReadLine());
            WTF[] arr = new WTF[num];
            for (int i = 0; i < arr.Length; i++)
            {
                WTF arWtf = new WTF(i, i, i);
                arr[i] = arWtf;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Информация сохранена в файл: ");
            Console.WriteLine();
            Console.WriteLine();
            WTF.Table(arr);

            arr[2].a = 4;
            arr[2].b = 6;
            arr[2].c = 9;
            for (int i = 0; i < arr.Length; i++)
            {


                if (i == 0)
                {
                    using (StreamWriter sw = new StreamWriter(@"C:\Users\alecs\Downloads\30-master\30-master\30\t.txt", false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(arr[i].Specifications());

                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(@"C:\Users\alecs\Downloads\30-master\30-master\30\t.txt", true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(arr[i].Specifications());

                    }
                }
            }
            Console.WriteLine("Информация изменена: ");
            Console.WriteLine();
            Console.WriteLine();
            WTF.Table(arr);
            //НОВЫЙ КЛАСС НАСЛЕДОВАННЫЙ ОТ WTF
            int numWTH = int.Parse(Console.ReadLine());
            WTH[] arrWTH = new WTH[numWTH];
            for (int i = 0; i < arrWTH.Length; i++)
            {
                WTH arWTH;
                if (i%2==0)
                {
                    arWTH = new WTH(i, i, i, "red");
                }
                else
                {
                    arWTH = new WTH(i, i, i, "yellow");
                }
                arrWTH[i] = arWTH;
            }
            WTH.TableWTH(arrWTH);
            Console.WriteLine();
            Console.WriteLine("Только  жёлтые фигуры:");
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                
                    if (i == -1)
                    {
                        Console.Write("№ Обьекта:" + "\t");

                    }
                    else if (i == 0)
                    {
                        Console.Write("a Обьектов " + "\t");
                    }
                    else if (i == 1)
                    {
                        Console.Write("b Обьектов " + "\t");
                    }
                    else if (i == 2)
                    {
                        Console.Write("c Обьектов " + "\t");
                    }

                    else if (i == 3)
                    {
                        Console.Write("Площадь: " + "\t");
                    }
                    else if (i == 4)
                    {
                        Console.Write("Обьём:   " + "\t");
                    }
                    else if (i == 5)
                    {
                        Console.Write("Цвет:    " + "\t");
                    }
                    for (int j = 0; j < arrWTH.Length; j++)
                    {
                    if (arrWTH[j].color == "yellow")
                    {
                        if (i == -1)
                        {
                            Console.Write(j + 1 + "\t");
                        }
                        else if (i == 0)
                        {
                            Console.Write(arrWTH[j].a + "\t");
                        }
                        else if (i == 1)
                        {
                            Console.Write(arrWTH[j].b + "\t");
                        }
                        else if (i == 2)
                        {

                            Console.Write(arrWTH[j].c + "\t");
                        }
                        else if (i == 3)
                        {
                            Console.Write(arrWTH[j].Sqare() + "\t");
                        }
                        else if (i == 4)
                        {
                            Console.Write(arrWTH[j].Valume() + "\t");
                        }
                        else if (i == 5)
                        {
                            Console.Write(arrWTH[j].color + "    ");
                        }
                    }

                    }
                    Console.WriteLine("\n \n ");
                
            }
            
            


        }
    }
    class WTH : WTF
    {
        public string color;
        public WTH(int _a, int _b, int _c, string _color)
       :base(_a, _b, _c)
        {
            color = _color;
        }
        
        public override string Specifications()
        {
            string strr = $"a: {a} b: {b} c: {c}, Цыет:{color} Площадь: {Sqare()}, Обьём: {Valume()}";
            return strr;
        }
        static public void TableWTH(WTH[] arr)
        {
            for (int i = -1; i < 6; i++)
            {
                if (i == -1)
                {
                    Console.Write("№ Обьекта:" + "\t");

                }
                else if (i == 0)
                {
                    Console.Write("a Обьектов " + "\t");
                }
                else if (i == 1)
                {
                    Console.Write("b Обьектов " + "\t");
                }
                else if (i == 2)
                {
                    Console.Write("c Обьектов " + "\t");
                }

                else if (i == 3)
                {
                    Console.Write("Площадь: " + "\t");
                }
                else if (i == 4)
                {
                    Console.Write("Обьём:   " + "\t");
                }
                else if (i == 5)
                {
                    Console.Write("Цвет:    " + "\t");
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == -1)
                    {
                        Console.Write(j + 1 + "\t");
                    }
                    else if (i == 0)
                    {
                        Console.Write(arr[j].a + "\t");
                    }
                    else if (i == 1)
                    {
                        Console.Write(arr[j].b + "\t");
                    }
                    else if (i == 2)
                    {

                        Console.Write(arr[j].c + "\t");
                    }
                    else if (i == 3)
                    {
                        Console.Write(arr[j].Sqare() + "\t");
                    }
                    else if (i == 4)
                    {
                        Console.Write(arr[j].Valume() + "\t");
                    }
                    else if (i == 5)
                    {
                        Console.Write(arr[j].color + "    ");
                    }

                }
                Console.WriteLine("\n \n ");
            }
        }
    }
        class WTF
    {
        
        public int a;
        public int b;
        public int c;
        public WTF(int _a, int _b, int _c)
        {
            a = _a;
            b = _b;
            c = _c;
           

        }
        
        public virtual string  Specifications()
        {
            string strr = $"a: {a} b: {b} c: {c}, Площадь: {Sqare()}, Обьём: {Valume()}";
            return strr;
        }
        static public void Table(WTF[] arr)
        {
            for (int i = -1; i < 5; i++)
            {
                if (i == -1)
                {
                    Console.Write("№ Обьекта:" + "\t");

                }
                else if(i == 0)
                {
                    Console.Write("a Обьектов " + "\t");
                }
                else if (i == 1)
                {
                    Console.Write("b Обьектов " + "\t");
                }
                else if (i == 2)
                {
                    Console.Write("c Обьектов " + "\t");
                }

                else if (i == 3)
                {
                    Console.Write("Площадь: " + "\t");
                }
                else if (i == 4)
                {
                    Console.Write("Обьём:   " + "\t");
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == -1)
                    {
                        Console.Write(j+1 + " ");
                    }
                    else if (i == 0)
                    {
                        Console.Write(arr[j].a+" ");
                    }
                    else if(i == 1)
                    {
                        Console.Write(arr[j].b + " ");
                    }
                    else if (i == 2)
                    {
                        
                        Console.Write(arr[j].c + " ");
                    }
                    else if (i == 3)
                    {
                        Console.Write(arr[j].Sqare() + " ");
                    }
                    else if (i == 4)
                    {
                        Console.Write(arr[j].Valume()+" ");
                    }

                }
                Console.WriteLine("\n \n ");
            }
        }


        public int Sqare()
        {
            return a * b;
        }
        public int Valume()
        {
            return a * b* c;
        }
    }
}