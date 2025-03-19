using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class SimpleDataBase<T>
{
    private List<T> storeData;
    private List<DateTime> inputDates;

    public SimpleDataBase() {
        storeData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void addNewData(T data) { 
        storeData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storeData.Count; i++) {
            Console.WriteLine($"Data {i+1} berisi: {storeData[i]}, yang disimpan pada waktu UTC :{inputDates[i]}");
        }
    }
}

class program
{
    static void Main()
    {
        SimpleDataBase<string> nim = new SimpleDataBase<string>();
        nim.addNewData("10");
        nim.addNewData("30");
        nim.addNewData("22");
        nim.PrintAllData();
    }
}