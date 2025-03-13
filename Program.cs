// class kodeProduk
//{ 
//    private static Dictionary<string, string> kodeProduk2 = new Dictionary<string, string>()
//    {
//        {"Laptop", "E100"},
//        {"Smartphone", "E101"},
//        {"Tablet", "E102"},
//        {"Headset", "E103"},
//        {"Keyboard", "E104"},
//        {"Mouse", "E105"},
//        {"Printer", "E106"},
//        {"Monitor","E107" },
//        {"Smartwatch","E108" },
//        {"Kamera", "E109" }
//    };

//    public static string getKodeProduk(string produk)
//    {
//        if (kodeProduk2.ContainsKey(produk))
//        {
//            return kodeProduk2[produk];
//        } else
//        {
//            return "Produk tidak ditemukan";
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Masukkan nama produk: ");
//        string produk = Console.ReadLine();

//        string kodeProdukk = kodeProduk.getKodeProduk(produk);
//        Console.WriteLine($"Kode produk: { kodeProdukk}");
//    }
//}

class fanLaptop
{
    private enum state { Performance, Quiet, Turbo, Balanced };
    private state currState;

    public fanLaptop()
    {
        currState = state.Quiet;
        Console.WriteLine("Fan dalam kondisi Quite Mode");
    }

    public void QuietMode()
    {
        if (currState == state.Quiet)
        {
            Console.WriteLine("\nFan telah masuk kedalam kondisi Quiet Mode");
        }
        else
        {
            currState = state.Quiet;
            Console.WriteLine("\nFan dalam kondisi Quite Mode");

        }
    }

    public void TurboMode()
    {
        if (currState == state.Turbo)
        {
            Console.WriteLine("\nFan Quiet berubah menjadi Turbo");
        }
        else
        {
            currState = state.Performance;
            Console.WriteLine("\nFan dalam kondisi Turbo Mode");

        }
    }
    public void balancedMode()
    {
        if (currState == state.Balanced)
        {
            Console.WriteLine("\n“Fan Quiet berubah menjadi Balanced");
        }
        else
        {
            currState = state.Balanced;
            Console.WriteLine("\nFan dalam kondisi Balanced Mode");

        }
    }
    public void performanceMode()
    {
        if (currState == state.Performance)
        {
            Console.WriteLine("\n“Fan Quiet berubah menjadi Performance");
        }
        else
        {
            currState = state.Performance;
            Console.WriteLine("\nFan dalam kondisi Performance Mode");

        }
    }

}

class Program
{
    static void Main()
    {
        fanLaptop fan = new fanLaptop();

        while (true)
        {
            Console.Write("Input: ");
            string command = Console.ReadLine().ToLower();

            if (command == "quiet")
                fan.QuietMode();
            else if (command == "turbo")
                fan.TurboMode();
            else if (command == "performance")
                fan.performanceMode();
            else if (command == "balanced")
                fan.balancedMode();
            else
                Console.WriteLine("Input tidak sesuai");
        }
    }
}

