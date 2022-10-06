namespace KyhOOpDemo;

// Christian
public class Person
{
    private int Age;
    private string Name;



    public Person(string namn, int age)
    {
        SetName(namn);
        SetAge(age);
    }
    //public Person() // DEFAULT CONSTRUCTOR
    //{
    //}

    public string GetName()
    {
        return Name;
    }
    public void SetName(string value)
    {
        if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 50)
            throw new ArgumentException("Felaktigt namn");
        Name = value;
    }

    public int GetAge()
    {
        return Age;
    }
    public void SetAge(int newAge)
    {
        if (newAge < 18 || newAge > 150)
        {
            throw new ArgumentException("Invalid new age");
        }
        else 
            Age = newAge;
    }

//    public string Name { get; set; }
//    public int Age { get; set; }
}