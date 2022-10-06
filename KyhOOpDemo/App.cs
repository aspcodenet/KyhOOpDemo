namespace KyhOOpDemo;

public class App
{
    // Elliot
    public void Run()
    {
        var allaPersoner = new List<Person>();
        var p = new Person();
        p.Name = "kalle";
        p.Age = 50;
        allaPersoner.Add(p);

        // 1. Skapa ny
        Console.Write("Namn:");
        var namn = Console.ReadLine();
        Console.Write("Age:");
        var age = Convert.ToInt32(Console.ReadLine());
        var person = new Person();
        person.Name = namn;
        person.Age = age;
        allaPersoner.Add(person);

        //2. Räkna ut medelåldern
        int summa = 0;
        foreach (var person2 in allaPersoner)
        {
            summa += person2.Age;
        }
        Console.WriteLine($"Medelåldern är:{Convert.ToSingle(summa) / allaPersoner.Count() }");

    }
}