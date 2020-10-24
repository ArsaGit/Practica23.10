using System;

namespace Practica23._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во студентов:");
            int num = GetInt();
            string[] students = new string[num];
            string[][] disciplines = new string[num][];
            int[][][] gradesTotal = new int[num][][];
            for(int i=0;i<num;i++)
            {
                //ввод имени
                Console.WriteLine("Введите имя студента");
                students[i] = Console.ReadLine();
                string str;
                do
                {
                    Console.WriteLine("Для выхода введите \"exit\"");
                    //ввод дисциплины
                    Console.Write("Введите название дисциплины():");
                    int j = 0;
                    str=Console.ReadLine();
                    if (str != "exit")
                    {
                        disciplines[i][j] = Console.ReadLine();
                        //ввод оценки
                        do
                        {
                            int k = 0;
                            Console.Write("Введите оценки через пробел:");
                            gradesTotal[i][j] = GetGrades();
                            k++;
                        }while()
                        j++;
                    }
                } while (str!="exit");
            }
        }
        static int GetInt()
        {
            int num;
            string str;
            do
            {
                str = Console.ReadLine(); 
            } while (int.TryParse(str, out num));
            return num;
        }
        static int[] GetGrades()
        {
            int[] grades;
            string str=Console.ReadLine();
            string[] arrayStr = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            do    //проверка правильности ввода фигуры 
            {
                int i = 0;

                i++;
            } while (int.TryParse(arrayStr, out grades[i]));
            
            return num;
        }

        static string[] GetInfo(int num)
        {
            Console.WriteLine("Введите данные студента:");
            Console.WriteLine("Пример:\nИванов Иван Иванович;Предмет(1,2,3,4 и т.д.):Предмет(...): и т.д.:");
            string[] array = new string[num];
            for (int i = 0; i < num; i++)
                array[i] = Console.ReadLine();
            return array;
        }
        static string[] GetNames(string[] studentsData)
        {
            var names = new string[studentsData.Length];
            foreach(string student in studentsData)
            {
                
            }
        }

    }
}
