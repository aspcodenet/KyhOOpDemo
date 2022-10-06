namespace KyhOOpDemo;

public class App
{

    public void Lab1()
    {
        var lunchList = new List<Dish>();
        var dish1 = new Dish("Pannkakor", 50, 10, DishType.Vegetarian);
        var dish2 = new Dish("Köttbullar", 70, 30, DishType.Meat);
        var dish3 = new Dish("Burgare", 100, 50, DishType.Meat);

        lunchList.Add(dish1);
        lunchList.Add(dish2);
        lunchList.Add(dish3);

        Console.WriteLine("VEGETARISK");
        foreach (var dish in lunchList)
        {
            if (dish.DishType == DishType.Vegetarian)
            {
                var currentPrice = dish.Price;
                Console.WriteLine($"{dish.Name} {dish.Calories}   {currentPrice}");
            }
        }

        Console.WriteLine("KÖTT");
        foreach (var dish in lunchList)
        {
            if (dish.DishType == DishType.Meat)
                Console.WriteLine($"{dish.Name} {dish.Calories}   {dish.Price}");
        }

        Console.WriteLine("VEGAN");
        foreach (var dish in lunchList)
        {
            if (dish.DishType == DishType.Vegan)
                Console.WriteLine($"{dish.Name} {dish.Calories}   {dish.Price}");
        }


    }

    // Elliot
    public void Run()
    {
        Lab1();

        var allaPersoner = new List<Person>();

        while (true)
        {
            try
            {
                Console.WriteLine("Ange namn:");
                var namn2 = Console.ReadLine();
                Console.WriteLine("Ange age:");
                var age1 = Convert.ToInt32(Console.ReadLine());
                var p = new Person(namn2, age1);
                allaPersoner.Add(p);
                break;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ngt gick fel " + ex.Message);
            }

        }


        // 1. Skapa ny
        Console.Write("Namn:");
        var namn = Console.ReadLine();
        Console.Write("Age:");
        var age = Convert.ToInt32(Console.ReadLine());
        var p2 = new Person(namn, age);
        p2.Age = 40;
        allaPersoner.Add(p2);

        //var person = new Person();
        //person.SetName("Stefan");
        //person.SetAge(age);
        //allaPersoner.Add(person);

        //2. Räkna ut medelåldern
        int summa = 0;
        foreach (var person2 in allaPersoner)
        {
            summa += person2.Age;
        }
        Console.WriteLine($"Medelåldern är:{Convert.ToSingle(summa) / allaPersoner.Count() }");

    }
}