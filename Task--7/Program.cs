using System.Security;

namespace Task__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementlerini
            //cap etmek  (c deyisheninin qiymeti istifadeciden sorushulur,hemcinin a massivinin elementleri de)
            //Yazdim
            int len;
            int numC;
        l1:
            len = ReadInt("1 ci Tapsirq: Massivde nece element olsun");
            if (len < 1)
            {
                Console.WriteLine("kifayet qeder eded yoxdu");
                goto l1;
            }
            int[] mass = new int[len];
            numC = ReadInt("C ededini daxil edin ");
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = ReadInt($"{i} - ci elementleri daxil edin");
            }
            Console.WriteLine("Elemnetler");
            foreach (var item in mass)
            {
                if (item < numC)
                {

                    Console.WriteLine(item);
                }

            }

            //================================================//
            //    //2.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementlerinin
            //    //ededi ortasini tapmaq^
            //YAZDIM
            int len2;
            int numC2;
        l2:
            len2 = ReadInt("2- ci tapsiriq: Massivde nece element olsun");
            if (len2 < 1)
            {
                Console.WriteLine("Kifayet qeder eded yoxdur");
                goto l2;
            }
            int[] mass2 = new int[len2];
            numC2 = ReadInt("(2 ci tapsiriqin) - C ededi");
            for (int j = 0; j < mass2.Length; j++)
            {
                mass2[j] = ReadInt($"{j} - ci elementleri daxil ediin");
            }
            int sum = 0;
            int count = 0;
            foreach (var item in mass2)
            {
                if (item < numC2)
                {
                    count++;
                    sum += item;
                }
            }
            Console.WriteLine($" Ededi ortasi: {sum / count}");
            //================================================//
            //3.  a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen
            //elementlerinin hendesi ortasini tapmaq  **Yazdim
            int len3;
            int numC3;
        l3:
            len3 = ReadInt("3 - cu tapsiriqdaki: MAssivi daxil edin");
            if (len3 < 1)
            {
                Console.WriteLine("EDED KIFAYET QEDEF DEYIL");
                goto l3;
            }
            int[] mass3 = new int[len3];
            numC3 = ReadInt("(3 cu tapsiriqin) C ededini daxil edin");
            for (int z = 0; z < mass3.Length; z++)
            {
                mass3[z] = ReadInt($"{z} - ci elementleri daxil edin");
            }
            int count3 = 0;
            int sum3 = 1;
            foreach (var item in mass3)
            {


                if (item < numC3)
                {
                    count3++;
                    sum3 *= item;

                }
            }
            Console.WriteLine(Math.Sqrt(sum3));
            //======================================//
            //    //4.  a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen elementlerini
            //    //coxdan aza dogru siralamaq
            int len4;
            int numC4;
        l4:
            len4 = ReadInt("4ci Tapsirq: Massivde nece element olsun");
            if (len4 < 1)
            {
                Console.WriteLine("kifayet qeder eded yoxdu");
                goto l4;
            }
            int[] mass4 = new int[len4];
            numC4 = ReadInt("C ededini daxil edin ");
            int[] numbers = Array.Empty<int>();
            for (int y = 0; y < mass4.Length; y++)
            {
                mass4[y] = ReadInt($"{y} - ci elementleri daxil edin");
            }
            Console.WriteLine("Elemnetler");
            for (int i = 0; i < mass4.Length; i++)
            {
                if (mass4[i] < numC4)
                {
                    Array.Resize(ref numbers, numbers.Length + 1);
                    numbers[numbers.Length - 1] = mass4[i];


                }


            }
            PrintArray(numbers);
            //================================//
            //5 // a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen
            // elementler icinden maximum elementi tapmaq
            //Yazdim

            int len5;
            int numC5;
        l5:
            len5 = ReadInt("5ci Tapsirq: Massivde nece element olsun");
            if (len5 < 1)
            {
                Console.WriteLine("kifayet qeder eded yoxdu");
                goto l5;
            }
            int[] mass5 = new int[len5];
            numC5 = ReadInt("C ededini daxil edin ");
            for (int l = 0; l < mass5.Length; l++)
            {
                mass5[l] = ReadInt($"{l} - ci elementleri daxil edin");
            }
            Console.WriteLine("Elemnetler");
            int max = mass5[0];
            for (int i = 0; i < mass5.Length; i++)
            {
                if (mass5[i] < numC5 && max < mass5[i])
                {
                    max = mass5[i];
                }
            }
            Console.WriteLine(max);
            //=======================================//
            //  6. X(n) ve Y(n) deye 2 massiv verilmishdir/Ele x[i] elementi tapmaq lazimdir ki
            //x[i] = y[i] ^ 2 (eyni indexdeki x elementi
            //hemin indexdeki y elementin kvadratina beraber olsun)
            //Yazzdim
            int[] massX = { 1, 2, 3, 16 };
            int[] massY = { 2, 45, 56, 4 };
            for (int b = 0; b < massX.Length; b++)
            {
                for (int r = 0; r < massY.Length; r++)
                {
                    if (massX[b] == massY[r] * massY[r])
                    {
                        Console.WriteLine(massX[b]);
                    }
                }
            }
            //==========================================///

            //7.  a massivinin (a[0],a[1] .... a[n]) en kicik ve en boyuk
            //elementlerinin hendesi ve ededi ortasini tapmali
            int[] mass7 = { 1, 4, 78, 90, 34, 80 };
            int coun7 = 0;
            int sum7 = 1;
            Console.WriteLine("Hendesi orta");
            foreach (int item7 in mass7)
            {
           
                coun7++;
                sum7 *= item7;
               
             
            }
            Console.WriteLine(Math.Sqrt(sum7));
            Console.WriteLine("Ededi ortasi");
            int countededOrta = 0;
            int sumortaEded = 0;
            foreach(int item71 in mass7)
            {
               countededOrta++;
                sumortaEded += item71;
               
            }
            Console.WriteLine($"{sumortaEded / countededOrta}");







            //8.  Heriri 14 elementli 2 massivin uygun elementlerini bir birine
            //vurub?alinan musbet hasillerden  yeni massiv duzeltmeli
            int[] mass8 = { 1, 3, 6, 8, 10, 67 };
            int[] newMass8 = { 1, 3, 5, 7, 8, 10 };
            for (int i = 0; i < mass8.Length; i++)
            {
                for (int j = 0; j < newMass8.Length; j++)
                {
                    int yekun = mass8[i] * newMass8[j];
                    int[] result8 = new int[yekun];
                    Console.WriteLine(yekun);
                }
            }
            //===================================================.
            //9.  25 elementli massivin ilk 8 elementini kvadrata yukseltmeli,qalanini
            //ise 4-e bolub,yeni iki massiv duzeltmeli
            int[] myArray = new int[25];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 1;
            }
            for (int i = 0; i < 8; i++)
            {

                myArray[i] = myArray[i] * myArray[i];

            }
            Console.WriteLine("Netice:");
            foreach (int num in myArray)
            {
                int[] emptyIntArray = new int[8];
                Array.Copy(myArray, emptyIntArray, 8);
                PrintArray(emptyIntArray);
                break;
            }

            Console.WriteLine("4 bolunmesinden alinan netice");
            for (int i = 8; i < 25; i++)
            {

                myArray[i] = myArray[i] / 4;
            }
            foreach (int num9 in myArray)
            {
                int[] emptyIntArray2 = new int[17];
                Array.Copy(myArray, 8, emptyIntArray2, 0, 17);
                PrintArray(emptyIntArray2);
                break;
            }

            //==========================================//
            // 10.X(n) massivinden ancaq menfi elementlerin maximum elementi tapin
            //YAzdim
            int[] minMass = { -1, -2, -3, -4 };
            for (int w = 0; w < minMass.Length; w++)
            {
                if (minMass[w] < minMass[0])
                {

                }
            }
            Console.WriteLine("------------------------");
            Console.WriteLine(minMass.Max());
            //=====================================//
            //11.X(n) massivinin elementlerini random olaraq 0 - 100 arasi
            //ededlerle doldurub,sonra ise azalma sirasina gore duzmeli
            int[] mass11 = { 1, 45, 89, 90, 56, 78, 99 };
            Array.Sort(mass11);
            Array.Reverse(mass11);
            PrintArray(mass11);
            //====================================//
            //  12. X(20) massivinin ilk yarisinin ededi ortasini
            //  ikinci yarisinin hendesi ortasini tapmaq
            //YAzdim
            int[] mass12 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int count12 = 0;
            double sum12 = 0;
            for (int s = 0; s < 10; s++)
            {
                count12++;
                sum12 += mass12[s];

            }
            Console.WriteLine($"Ededi ortasi = {sum12 / count12}");
            int sum121 = 0;
            int count121 = 0;

            for (int c = 10; c < 20; c++)
            {
                count121++;
                sum121 *= mass12[c];

            }



            Console.WriteLine($"Hendesi orta = {Math.Sqrt(sum121)}");




        }
        static void PrintArray(Array arr)
        {
            Console.WriteLine("===================================================");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n===================================================");

        }
        static int ReadInt(string text)
        {
            Console.WriteLine(text);
            string aStr = Console.ReadLine();
            int input = Convert.ToInt32(aStr);
            return input;
        }
    }
    }

