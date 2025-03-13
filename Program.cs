 class kodeProduk
{ 
    private static Dictionary<string, string> kodeProduk2 = new Dictionary<string, string>()
    {
        {"Laptop", "E100"},
        {"Smartphone", "E101"},
        {"Tablet", "E102"},
        {"Headset", "E103"},
        {"Keyboard", "E104"},
        {"Mouse", "E105"},
        {"Printer", "E106"},
        {"Monitor","E107" },
        {"Smartwatch","E108" },
        {"Kamera", "E109" }
    };

    public static string getKodeProduk(string produk)
    {
        if (kodeProduk2.ContainsKey(produk))
        {
            return kodeProduk2[produk];
        } else
        {
            return "Produk tidak ditemukan";
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Masukkan nama produk: ");
        string produk = Console.ReadLine();

        string kodeProdukk = kodeProduk.getKodeProduk(produk);
        Console.WriteLine($"Kode produk: { kodeProdukk}");
    }
}
