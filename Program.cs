// See https://aka.ms/new-console-template for more information


using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


class program
{
    class simpleSimpleDataBase<T>
    {
        private List<T> storedData = new List<T>();
        private List<DateTime> inputDates= new List<DateTime> ();

        public void SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }
        public void AddData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine(storedData[i] + " (" + inputDates[i] + ")");
            }
        }



    }
    static void Main()
    {
        simpleSimpleDataBase<long> simpleDB = new simpleSimpleDataBase<long>();
        simpleDB.AddData(10);
        simpleDB.AddData(30);
        simpleDB.AddData(22);
        simpleDB.PrintAllData();



    }
}



namespace tpmodul5_103022300009
{
    class PemrosesData<T>
    {
        // Properti data dengan tipe data generik
        private T data;

        // Konstruktor
        public PemrosesData(T data)
        {
            this.data = data;
        }

        // Method PrintData 
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {data}");
        }

        public T DapatkanNilaiTerbesar<T>(T angka1, T angka2, T angka3)
        {
            dynamic temp = (dynamic)angka1;
            dynamic temp2 = (dynamic)angka2;
            dynamic temp3 = (dynamic)angka3;
            dynamic max = temp;

            if (temp2 > max)
            {
                max = temp2;
            }
            if (temp3 > max)
            {
                max = temp3;
            }
            return max;
        }


    }

    internal class program
    {
        static void Main(string[] args)
        {
            PemrosesData<long> pemrosesData = new PemrosesData<long>(0);
            Console.WriteLine($"Nilai terbesar adalah: {pemrosesData.DapatkanNilaiTerbesar(10, 30, 22)}");

        }
    }
}

       

