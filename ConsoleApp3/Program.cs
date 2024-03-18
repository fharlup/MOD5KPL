using System;

public class Penjumlahan<T> where T : struct
{
    public T Satu { get; private set; }
    public T Dua { get; private set; }
    public T Tiga { get; private set; }
    int hasil;

    public void JumlahTigaAngka(T satu, T dua, T tiga)
    {
        this.Satu = satu;
        this.Dua = dua;
        this.Tiga = tiga;
        dynamic satua = satu;
        dynamic duaa = dua;
        dynamic tigaa = tiga;
        dynamic hasil = satua + duaa + tigaa;
        Console.WriteLine(hasil);


    }
   
}
public class SimpleDataBase<T> 

{

    List<DateTime> InputDate;
    List<T> StoreData;
    public  SimpleDataBase()
    {
        this.StoreData = new List<T>();
        InputDate = new List<DateTime>();
    }
    public void addNewData (T NewData)
    {
        StoreData.Add(NewData);
        InputDate.Add(DateTime.Now);
    }
    public void Printdata()
    {
        for(int i=0; i<StoreData.Count; i++)
        {
            Console.WriteLine($"Data {i+1} berisi: {StoreData.ElementAt(i)}, yang disimpan pada waktu {InputDate.ElementAt(i)}");
        }
    }
}
 public class Program
    {
        public static void Main(string[] args)
        {
            Penjumlahan<float> penjumlah = new Penjumlahan<float>();
            penjumlah.JumlahTigaAngka(1, 2, 3);
            SimpleDataBase <string>data1=new SimpleDataBase<string>();
        SimpleDataBase<string> data2 = new SimpleDataBase<string>();
        data1.addNewData("12");
        data1.addNewData("34");
        data1.addNewData("34");
        data1.Printdata();
        



        }
    }

























