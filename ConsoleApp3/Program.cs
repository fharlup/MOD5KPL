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
 public class Program
    {
        public static void Main(string[] args)
        {
            Penjumlahan<float> penjumlah = new Penjumlahan<float>();
            penjumlah.JumlahTigaAngka(1, 2, 3);




        }
    }

























