using System;

class PemrosesData
{
    public void DapatkanNilaiTerbesar<T>(T input, T input1, T input2) {
        dynamic temp1 = (dynamic)input;
        dynamic temp2 = (dynamic)input1;
        dynamic temp3 = (dynamic)input2;
        dynamic largest = temp1;

        if (temp2 > largest)
        {
            largest = temp2;
        }
        else if (temp3 > largest) {
            largest = temp3;
        }
        Console.WriteLine(largest);
    }

    class program {
        static void Main() {
            PemrosesData nilai = new PemrosesData();
            double input = 10;
            double input1 = 30;
            double input2 = 22;
            nilai.DapatkanNilaiTerbesar(input, input1, input2); 
        }
    }
}