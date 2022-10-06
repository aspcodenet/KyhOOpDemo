namespace KyhOOpDemo;

public class App
{
    // Elliot
    public void Run()
    {
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