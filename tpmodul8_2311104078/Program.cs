using System;

class Program
{
    static void Main()
    {
        CovidConfig config = new CovidConfig();

        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}: ");
        double suhu = double.Parse(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        int hari = int.Parse(Console.ReadLine());

        bool suhuNormal = (config.satuan_suhu == "celcius" && suhu >= 36.5 && suhu <= 37.5) ||
                          (config.satuan_suhu == "fahrenheit" && suhu >= 97.7 && suhu <= 99.5);
        bool hariValid = hari < config.batas_hari_deman;

        if (suhuNormal && hariValid)
        {
            Console.WriteLine(config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.pesan_ditolak);
        }

        // Contoh pemanggilan method ubah satuan
        config.UbahSatuan();
        Console.WriteLine($"Satuan suhu sekarang diubah menjadi: {config.satuan_suhu}");
    }
}
