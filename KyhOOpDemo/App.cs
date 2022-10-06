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
                //var p = new Person();
                //Console.WriteLine("Ange namn:");
                //p.SetName(Console.ReadLine());
                //Console.WriteLine("Ange age:");
                //p.SetAge(Convert.ToInt32(Console.ReadLine()));
                //allaPersoner.Add(p);
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
        //var person = new Person();
        //person.SetName("Stefan");
        //person.SetAge(age);
        //allaPersoner.Add(person);

        //2. Räkna ut medelåldern
        int summa = 0;
        foreach (var person2 in allaPersoner)
        {
            summa += person2.GetAge();
        }
        Console.WriteLine($"Medelåldern är:{Convert.ToSingle(summa) / allaPersoner.Count() }");

    }
}