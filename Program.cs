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


