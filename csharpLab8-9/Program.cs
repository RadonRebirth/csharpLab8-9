using System;

namespace csharpLab8_9
{
    public class Massiv<T>
    {
        public T[] array;
        public Massiv(int size) => array = new T[size];

        public void Add(int index, T item) => array[index] = item; 

        public void Delete(T item)
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            if (index > -1)
            {
                T[] newItem = new T[array.Length - 1];
                for (int i = 0, j = 0; i < array.Length; i++)
                {
                    if (i == index) continue;
                    newItem[j] = array[i];
                    j++;
                }
                array = newItem;
            }
        }
            
        public T GetItem(int index)
        {
            return array[index];
        }
        public int getLenght()
        {
            return array.Length;
        }
    }

    public class Log : Massiv<string> 
    {
        public Log(int size) : base(size) { }
    }
    public class Pass : Massiv<string>
    {
        public Pass(int size) : base(size) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Massiv<int> myIntArray = new Massiv<int>(5);
            Massiv<string> myStringArray = new Massiv<string>(8);
            Massiv<double> myDoubleArray = new Massiv<double>(15);
            Log login = new Log(5);
            Pass password = new Pass(8);

            login.Add(0,"login");
            password.Add(0,"qwerty123");

            Console.WriteLine($"Аккаунт: {login.GetItem(0)} ; {password.GetItem(0)}");

            login.Delete("login");

            Console.WriteLine($"Аккаунт: {login.GetItem(0)} ; {password.GetItem(0)}");

            Console.ReadKey();
        }
    }
}
