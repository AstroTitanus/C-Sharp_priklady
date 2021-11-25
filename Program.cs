using System;
using System.Linq;
using System.Collections.Generic;

namespace dv_1
{
    class Switch
    {
        public static void SwitchMethod(int a = 2)
        {
            switch (a)
            {
            case 1:
                Console.WriteLine("premenna 'a' ma hodnotu 1");
                break;
            case 2:
                Console.WriteLine("premenna 'a' ma hodnotu 2");
                break;
            case 3:
                Console.WriteLine("premenna 'a' ma hodnotu 3");
                break;
            default:
                Console.WriteLine($"premenna 'a' ma hodnotu {a}");
                break;
            }
        }
    }



    class Cykly
    {
        public static void DoLoop()
        {
            int i = 0;
            do {
                Console.WriteLine(i);
                i++;
            } while(i < 10);
        }

        public static void WhileLoop()
        {
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

    }



    class Pole
    {
        public static void PoleMethod()
        {
            int[] arr = {1, 2, 3, 4, 5};

            int index = 3;
            if (index < arr.Length)
            {
                Console.WriteLine($"hodnota pola 'arr' na mieste {index} je {arr[index]}");
            }
            else
            {
                Console.WriteLine("Premenna 'index' nesmie byt vacsia ako dlzka pola minus 1");
            }
        }

        public static void MinMax()
        {
            int[] arr = {1, 2, 3, 4, 5};

            int max = arr.Max();
            int min = arr.Min();
            int sum = arr.Sum();

            Console.WriteLine($"Najvyssia hodnota v poli: {max}");
            Console.WriteLine($"Najnizsia hodnota v poli: {min}");
            Console.WriteLine($"Sucet hodnot v poli: {sum}");
        }

        public static void SekvencneVyhladavanie(int ToFind = 12)
        {
            int[] arr = {1, 5, 2, 12, 54, 23, 2, 6, 3, 74, 12, 16, 26};

            // Manualne; Najde index prveho vyskytu prvku s danou hodnotou
            int i = 0;
            while (i < arr.Length && arr[i] != ToFind)
            {
                i++;
            }

            if (i < arr.Length)
            {
                Console.WriteLine($"Hodnota {ToFind} bola najduta v poli 'arr' na indexe {i}");
            }
            else
            {
                Console.WriteLine($"Hodnota {ToFind} nebola v poli 'arr' najduta.");
            }

            // Cez metodu IndexOf
            int index = Array.IndexOf(arr, ToFind);

            if (index >= 0)
            {
                Console.WriteLine($"Hodnota {ToFind} bola najduta v poli 'arr' na indexe {index}");
            }
            else
            {
                Console.WriteLine($"Hodnota {ToFind} nebola v poli 'arr' najduta.");
            }

        }

        public static void BubbleSort()
        {
            int[] arr = {1, 5, 2, 12, 54, 23, 2, 6, 3, 74, 12, 16, 26};

            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

        }

        public static void InsertionSort()
        {
            int[] arr = {1, 5, 2, 12, 54, 23, 2, 6, 3, 74, 12, 16, 26};

            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != 0 && arr[i] < arr[i - 1])
                {
                    int j = i;
                    while (j > 0 && arr[j] < arr[j - 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                        j--;
                    }
                }
            }

            foreach (int i in arr)
            {
                Console.Write(i.ToString() + "  ");
            }
        }

        public static void BinarySearch()
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
            int toFind = 12;

            int minIndex = 0;
            int maxIndex = arr.Length - 1;

            while (minIndex <= maxIndex)
            {
                int middle = minIndex + (maxIndex - minIndex) / 2;   
                if (toFind < arr[middle])
                {
                    maxIndex = middle - 1;
                }
                else if ( toFind > arr[middle])
                {
                    minIndex = middle + 1;
                }
                else if (toFind==arr[middle])
                {
                    Console.WriteLine($"Hodnota {toFind} bola najduta v poli 'arr' na indexe {middle}");
                    break;
                }       
            }

            if (minIndex > maxIndex)
            {
                Console.WriteLine($"Hodnota {toFind} nebola v poli 'arr' najduta.");
            }
        }

        public static void Copy()
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8};
            int[] arrCopied = new int[arr.Length];

            Array.Copy(arr, arrCopied, arr.Length);

            foreach (int i in arrCopied) 
                Console.Write($"{i} ");
        }

        public static void Porovnanie()
        {
            int[] arr1 = {1, 2, 3, 4, 5, 6, 7, 8};
            int[] arr2 = {1, 2, 3, 4, 5, 6, 7, 8};

            bool equal = Enumerable.SequenceEqual(arr1, arr2);
            if (equal) {
                Console.WriteLine("Polia su rovnake");
            }
            else
            {
                Console.WriteLine("Polia nie su rovnake");
            }
        }

        public static void MultiDimensional()
        {
            int[,] multiDimArr = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
            Console.WriteLine(multiDimArr[0, 0]);
            Console.WriteLine(multiDimArr[1, 0]);
            Console.WriteLine(multiDimArr[2, 0]);
            Console.WriteLine("--");

            int[,,] moreDimArr =
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 }
                },
                {
                    { 7, 8, 9 },
                    { 4, 5, 2 }
                },
                {
                    { 9, 2, 7 },
                    { 2, 5, 4 }
                },
                {
                    { 4, 6, 3 },
                    { 4, 5, 9 }
                }
            };
            Console.WriteLine(moreDimArr[0, 0, 0]);
            Console.WriteLine(moreDimArr[0, 1, 0]);
            Console.WriteLine(moreDimArr[1, 0, 0]);
            Console.WriteLine(moreDimArr[1, 1, 0]);
            Console.WriteLine(moreDimArr[2, 0, 0]);
            Console.WriteLine(moreDimArr[2, 1, 0]);
            Console.WriteLine(moreDimArr[3, 0, 0]);
            Console.WriteLine(moreDimArr[3, 1, 0]);
        }

        public static void test()
        {
            int a = 5;
            int b;
            b = a;
            a = 3;
            Console.WriteLine(b);

            int[] arr = {1, 2, 3, 4, 5, 6};
            int[] arr2 = arr;
            arr[2] = 54;
            Console.WriteLine(arr2[2]);
        }

    }



    // #--------------------------------------------------------#
    // | Cvicenia s classmi (Trida, definice, fieldy, instance) |
    // #--------------------------------------------------------#

    class Student
    {
        public int id {get; set;}  // automaticky vytovori private field a setupne mu getter a setter cez property
        public string meno {get; set;}
    }

    class StudentRunner
    {
        public static void Run()
        {
            Student student = new Student();
            student.id = 1;
            student.meno = "Juraj";

            Console.WriteLine($"Objekt 'student' s menom {student.meno} ma id s hodnotou {student.id}");
        }
    }



    // #------------------------------------------------------------------------------------------------#
    // | Cvicenia s classmi (Metody, konstruktory, modifikatory pristupu, property, Object Initializer) |
    // #------------------------------------------------------------------------------------------------#

    class Auto
    {
        public string meno {get; set;}
        public int rocnik {get; set;}
        public int pocetKolies {get; set;}
        public int najazdeneKM {get; private set;} // Nemozem priradit hodnotu v Object Initializeri, pretoze set je private

        public Auto(string meno, int rocnik, int pocetKolies)
        {
            this.meno = meno;
            this.rocnik = rocnik;
            this.pocetKolies = pocetKolies;
            this.najazdeneKM = 10;
        }

        private void pridajKM(int pocetKM)
        {
            this.najazdeneKM += pocetKM;
        }

        public void ide()
        {
            Console.WriteLine("Brm Brm!");
            pridajKM(1);
            Console.WriteLine(this.najazdeneKM);
        }

        public void zatrubi()
        {
            Console.WriteLine("TUTUUUUT!");
        }
    }

    class AutoRunner
    {
        public static void Run()
        {
            Auto mojeAuto = new Auto("seat", 2005, 4);
            Console.WriteLine(mojeAuto.meno);
            Console.WriteLine(mojeAuto.rocnik);

            mojeAuto.ide();
            mojeAuto.zatrubi();
        }
    }



    // #--------------------------------------------------#
    // | Struct vs Class, zásobník a halda, Pole structov |
    // #--------------------------------------------------#

    struct MyType
    {
        public int num;
    }

    class Struct
    {
        public static void Demo()
        {
            MyType x = new MyType();
            MyType x1 = x; // vytvori sa novy zaznam na stacku
            x.num = 5; // je ulozeny na stacku
            x1.num = 6; // nezmeni povodne data, pretoze su ulozene inde
            Console.WriteLine(x.num);

            // Keby spravime rovnaku vec ale s objektami, videli by sme ze by sa zmenil aj povodny objekt, pretoze objekty
            // su referencne datove typy. Teda objekt uklada samotne data na heap a na stacku iba referenciu na data na heape.
        }

        public static void Arr()
        {
            MyType[] arr = new MyType[4];
            arr[0].num = 1;
            arr[1].num = 2;
            arr[2].num = 3;

            MyType singleCopy = arr[0];
            singleCopy.num = 5; //arr zostane neovplyvneny
            Console.WriteLine(arr[0].num);

            MyType[] arrCopy = arr;
            arrCopy[0].num = 5; //zmeni aj povodny arr lebo sa odkazuju na rovnake data na heape.
            Console.WriteLine(arr[0].num);
        }
    }



    // #---------------#
    // | Pole Objektov |
    // #---------------#

    class Trieda
    {
        public int x;
    }

    class Objekty
    {
        public static void Arr()
        {
            Trieda[] arr = new Trieda[4];
            arr[0] = new Trieda();
            arr[1] = new Trieda();
            arr[2] = new Trieda();

            Trieda singleCopy = arr[0];
            singleCopy.x = 5; //Zmeni aj povodny objekt v arr
            Console.WriteLine(arr[0].x);

            Trieda[] fullCopy = arr;
            fullCopy[1].x = 10; //Zmeni aj povodny objekt v arr
            Console.WriteLine(arr[1].x);
        } 
    }



    // #--------------#
    // | Foreach loop |
    // #--------------#

    class ForeachLoop
    {
        public static void Run()
        {
            int[] arr = {1, 2, 3, 4};

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }



    // #-------------#
    // | Ref and Out |
    // #-------------#

    class RefOut
    {
        public static void RefMethod(ref int x)
        {
            x++; // Operuje s rovnakou premennou ktora bola poslana do argumentu, nie s kopiou.
        }

        public static void RefDemo()
        {
            int i = 5; // musi byt inicializovana tu, nie v RefMethod funkcii
            RefMethod(ref i);
            Console.WriteLine(i);
        }

        public static void OutMethod(out int x)
        {
            x = 10; // Tiez operuje s rovnakou premmennou aka bola poslana do argumentu, ale musi byt inicializovana v tejto funkcii,
                    // alebo jej tu musi byt priradena hodnota
        }

        public static void OutDemo()
        {
            int i; // Moze, ale nemusi mat priradenu hodnotu tu.
            OutMethod(out i);
            Console.WriteLine(i);
        }
    }



    // #-----------------#
    // | List Operations |
    // #-----------------#

    class ListOperations
    {
        public static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\n");
        }

        public static void Demo()
        {
            List<int> intList = new List<int> {1, 2, 3, 4, 5, 6};
            PrintList(intList);

            intList.Add(7);
            PrintList(intList);

            intList.Remove(7);
            PrintList(intList);

            intList.RemoveAt(0);
            PrintList(intList);

            intList.Insert(0, 1);
            PrintList(intList);

            intList.RemoveRange(0, 2);
            PrintList(intList);
        }
    }



    // #------------------------------------#
    // | Multidimensional and Jagged arrays |
    // #------------------------------------#

    class SpecialArrays
    {
        public static void Demo()
        {
            // Multidimensional
            int[,] multiArray = new int[3, 3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            }; // Allocuje klasicke pole velkosti 3*3.
            
            Console.WriteLine("Multidimensional Array");
            foreach (int item in multiArray)
            {
                Console.Write($"{item} ");
            }


            // Jagged
            int[][] jaggedArray = new int[2][]; // Allocuje dve referencie na polia (teraz su na null)
            jaggedArray[0] = new int[] {1, 2}; // Allocuje pole o velkosti 2
            jaggedArray[1] = new int[] {3, 4, 5, 6}; // Allocuje pole o velkosti 3

            Console.WriteLine("\nJagged Array");
            foreach (int[] item in jaggedArray)
            {
                foreach (int num in item)
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }



    // #--------------#
    // | Dictionaries |
    // #--------------#

    class Dictionaries
    {
        public static void Demo()
        {
            Dictionary<int, string> someData = new Dictionary<int, string> {
                {1, "Jeden"},
                {2, "Dva"},
                {3, "Tri"}
            };

            someData.Add(4, "nieco");
            someData[4] = "Styri";
            
            foreach (var pair in someData)
            {
                Console.WriteLine($"id: {pair.Key}, value: {pair.Value}");
            }
        }
    }



    // #----------------------#
    // | Static clenske prvky |
    // #----------------------#

    class StaticThings
    {
        private static string _statickyField = "Som staticky";

        public string StatickaProperty
        {
            get { return _statickyField; }
            set { _statickyField = value; }
        }

        public static String StatickaMetoda()
        {
            Console.WriteLine("Returnujem StatickyField");
            return _statickyField;
        }
    }

    class StaticThingsDemo
    {
        public static void run()
        {
            StaticThings.StatickaMetoda();
        }
    }



    // #-------------------#
    // | Rekurzivne metody |
    // #-------------------#

    class Rekurzivne
    {
        public static int Faktorial(int num)
        {
            if (num < 0) { Console.WriteLine("Cislo v argumente musi byt kladne."); return 0; }

            if (num > 0)
            {
                return num * Faktorial(num - 1);
            }
            else
            {
                return 1;
            }
        }

        public static void Demo()
        {
            Console.WriteLine(Faktorial(5));
        }
    }



    // #------------#
    // | LinkedList |
    // #------------#

    class LinkedListDemo
    {
        static public void Run()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            Console.WriteLine($"Last: {list.Last.Value}");

            LinkedListNode<int> head = list.First;
            Console.WriteLine($"Head: {head.Value}");
            Console.WriteLine($"Head.Next: {head.Next.Value}");

        }
    }



    // #-----------------#
    // | Stack and Queue |
    // #-----------------#

    class StackQueue
    {
        static public void StackDemo()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int count = stack.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(stack.Pop());
            }
            // Na konci loopu je stack prazdny.
        }

        static public void QueueDemo()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            int count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
            // Na konci loopu je queue prazdny.
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            // Treba skusat jednen priklad po druhom. Ked sa odkomentuju vsetky tak je output neprehladny.
            Switch.SwitchMethod();
            // Cykly.DoLoop();
            // Cykly.WhileLoop();
            // Cykly.ForLoop();
            // Pole.PoleMethod();
            // Pole.MinMax();
            // Pole.SekvencneVyhladavanie();
            // Pole.BubbleSort();
            // Pole.InsertionSort();
            // Pole.BinarySearch();
            // Pole.Copy();
            // Pole.Porovnanie();
            // Pole.MultiDimensional();
            // StudentRunner.Run();
            // AutoRunner.Run();
            // Struct.Demo();
            // Struct.Arr();
            // Objekty.Arr();
            // ForeachLoop.Run();
            // RefOut.RefDemo();
            // RefOut.OutDemo();
            // ListOperations.Demo();
            // SpecialArrays.Demo();
            // Dictionaries.Demo();
            // StaticThingsDemo.run();
            // Rekurzivne.Demo();
            // LinkedListDemo.Run();
            // StackQueue.StackDemo();
            // StackQueue.QueueDemo();
        }
    }
}
