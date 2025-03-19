using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class PemrosesData
{
    public void DapatkanNilaiTerbesar<T>(T input, T input1, T input2)
    {
        dynamic temp1 = (dynamic)input;
        dynamic temp2 = (dynamic)input1;
        dynamic temp3 = (dynamic)input2;
        dynamic largest = temp1;

        if (temp2 > largest)
        {
            largest = temp2;
        }
        else if (temp3 > largest)
        {
            largest = temp3;
        }
        Console.WriteLine(largest);
    }

    
}

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
        PemrosesData nilai = new PemrosesData();
        double input = 10;
        double input1 = 30;
        double input2 = 22;
        nilai.DapatkanNilaiTerbesar(input, input1, input2);

        SimpleDataBase<string> nim = new SimpleDataBase<string>();
        nim.addNewData("10");
        nim.addNewData("30");
        nim.addNewData("22");
        nim.PrintAllData();
    }
}

