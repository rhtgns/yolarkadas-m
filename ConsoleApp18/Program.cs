class Program
{
    static void Main()
    {
        string[] lokasyonlar = { "Bodrum", "Marmaris", "Çeşme" };
        int[] lokasyonFiyatlari = { 4000, 3000, 5000 };
        string[] geziSecenekleri = { "Kara yolu", "Hava yolu" };
        int[] ulasimUcreti = { 1500, 4000 };

        string secilenLokasyon = "";
        int lokasyonFiyatı = 0;
        int kisiSayısı = 0;
        int secilenTatilücreti = 0;

        bool isSecilenLokasyon = false;
        while (isSecilenLokasyon)
        {
            Console.Write("Gitmek istediğiniz lokasyonu giriniz (Bodrum, Marmaris, Çeşme): ");
            string musteriLokasyon = Console.ReadLine();

            for (int i = 0; i < lokasyonlar.Length; i++)
            {
                if (musteriLokasyon.Equals(lokasyonlar[i], StringComparison.OrdinalIgnoreCase))
                {
                    secilenLokasyon = lokasyonlar[i];
                    lokasyonFiyatı = lokasyonFiyatlari[i];
                    isSecilenLokasyon = true;
                    break;

                }

            }
            if (!isSecilenLokasyon)
            {
                Console.WriteLine("Hatalı giriş yaptınız. Geçerli lokasyonlar: Bodrum, Marmaris, Çeşme");
            }

        }
        Console.Write("Kaç kişi için tatil planlamak istiyorsunuz? ");
        while (!int.TryParse(Console.ReadLine(), out kisiSayısı) || kisiSayısı <= 0)
        {
            Console.Write("Lütfen geçerli bir kişi sayısı giriniz: ");
        }
        bool isgeziSecenekleri = false;
        while (!isgeziSecenekleri)
        {
            Console.WriteLine("Tatiline ne şekilde gitmek istiyorsunuz?");
            Console.WriteLine("1 - Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)");
            Console.WriteLine("2 - Hava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
            Console.Write("Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz (1 veya 2): ");
            string geziiSecenekleri = Console.ReadLine();

            if (geziiSecenekleri == "1")
            {
                secilenTatilücreti = ulasimUcreti[0];
                isgeziSecenekleri = true;
            }
            else if (geziiSecenekleri == "2")
            {
                secilenTatilücreti = ulasimUcreti[1];
                isgeziSecenekleri = true;
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız. Lütfen 1 veya 2 seçeneklerinden birini seçiniz.");
            }
        }
        int totalCost = (lokasyonFiyatı + secilenTatilücreti) * kisiSayısı;

        Console.WriteLine($"\nGitmek istediğiniz lokasyon: {secilenLokasyon}");
        Console.WriteLine($"Kişi sayısı: {kisiSayısı}");
        Console.WriteLine($"Ulaşım şekli: {(secilenTatilücreti == 1500 ? "Kara yolu" : "Hava yolu")}");
        Console.WriteLine($"Toplam maliyet: {totalCost} TL");
    }
}
