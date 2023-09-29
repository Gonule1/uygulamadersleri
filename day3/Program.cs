//string ad = "Gülsu Doğan";
//Console.WriteLine($" ad metninde ğ harfi var mı: {ad.Contains("ğ")}" );
//Console.WriteLine( ad.ToUpper());

////collections
//using System.Net;
//using System.Numerics;

//string[] sehirler = { "Elazığ", "Kahramanmaraş", "Malatya","Ankara"};

////Console.WriteLine(sehirler[0]);
////Console.WriteLine(sehirler[1]);
////Console.WriteLine(sehirler[2]);

//for (int i=0; i<sehirler.Length;i++ )
//{
//    Console.WriteLine(sehirler[i]);
//}
//int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//foreach(int sayi in sayilar)
//{
//    Console.WriteLine(sayi);
//}


//List<string>meyveler= new List<string>()
//{
//    "Karpuz","çilek","elma"
//};
//meyveler.Add("kavun");
//meyveler.Add("armut");
//List<string> eklenecekMeyveler = new List<string>()
//{
//    "ejderha meyvesi","mango"
//};
//meyveler.AddRange(eklenecekMeyveler);

//foreach(string meyve in meyveler)
//{
//    Console.WriteLine(meyve);
//}

//meyveler.ForEach(meyve=> Console.WriteLine(meyve));

//List<int> numbers = new()
//{
//    1,4,2,3,7,6,8,9,11,10
//};
//numbers.Sort(); // küçükten büyüğe sıralar
//numbers.Reverse(); //büyükten küçüğe sıralar

//numbers.ForEach(numbers=> Console.WriteLine(numbers));
//numbers.Remove(7);  // listeden 7yi siler
//Console.WriteLine($"listtedeki 3 olan değerin indeksi: {numbers.IndexOf(3)} ");
//Console.WriteLine($"listedeki sayıların toplamı: {numbers.Sum()}");
//Console.WriteLine($"listedeki sayıların en küçük sayı: {numbers.Min()}");
//Console.WriteLine($"listedeki sayıların en büyük sayı: {numbers. Max()}");

//List<int> numbers1 = new()
//{
//    1,4,2,3,7,6,8,9,11,10
//};
//List<int> evenNumbers = new();
//foreach (int number in numbers1)
//{
//    if (number % 2 == 0)
//    {
//        evenNumbers.Add(number);
//    }
//}
//foreach(int ciftsayi in evenNumbers)
//{
//    Console.WriteLine(ciftsayi);
//}

//evenNumbers = numbers1.FindAll(even=> even %2==0);
//evenNumbers.ForEach(number=> Console.WriteLine(number));

// sebzeler listesine 3 tane eleman ekleyin ve 3 elemanı listeleyin ve listede 2. indeksteki sebze adını ekrana bastırın
// bu listede küçük harflerle yazılan sebzeleri büyük harflerle yazın

List<string> sebzeler = new List<string>()
{
    "domates","biber","patlıcan"
};
foreach( string sebze in sebzeler)
{
    Console.WriteLine(sebze);

}

Console.WriteLine( sebzeler[2]);
sebzeler.ForEach(sebze=> Console.WriteLine(sebze.ToUpper()));