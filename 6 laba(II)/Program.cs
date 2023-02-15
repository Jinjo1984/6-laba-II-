

public class Listing 
{
   public string name { get; set; }
   public int Age { get; set; }
   public string Country { get; set; }    
}

public class main
{
    static void Main()
    {
        Listing person1 = new Listing() { name = "bob", Age = 34, Country = "spanish" };
        Listing person2 = new Listing() { name = "Jon", Age = 23, Country = "Franch" };
        Listing person3 = new Listing() { name = "Nikola", Age = 34, Country = "Russia" };
        List<Listing> listing = new List<Listing>
        {
            person1,
            person2,
            person3
        };

        Console.WriteLine("Вывод списка\nКакой список вывести?");
        int casee = Convert.ToInt32(Console.ReadLine());
        switch (casee)
        {
            case (1):
                Console.WriteLine($"{listing[0].name} {listing[0].Age} {listing[0].Country}");
                break;
            case (2):
                Console.WriteLine($"{listing[1].name} {listing[1].Age} {listing[1].Country}");
                break;
            case (3):
                Console.WriteLine($"{listing[2].name} {listing[2].Age} {listing[2].Country}");
                break;
        }
    }
}

