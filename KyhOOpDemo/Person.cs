namespace KyhOOpDemo;

// Christian

public enum PlayerPositionType
{
    Goalie,
    Defence,
    Forward
}
public class Person
{
    private int age;
    private string name;
    private PlayerPositionType playerPositon; 
    public PlayerPositionType PlayerPosition
    {
        get { return playerPositon; }
        set
        {
            playerPositon = value;
        }
    }


    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 50)
                throw new ArgumentException("Felaktigt namn");
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18 || value > 150)
            {
                throw new ArgumentException("Invalid new age");
            }
            age = value;
        }
    }


    //public string GetName()
    //{
    //    return Name;
    //}
    //public void SetName(string value)
    //{
    //    if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 50)
    //        throw new ArgumentException("Felaktigt namn");
    //    Name = value;
    //}




    public Person(string namn, int age)
    {
        Name = namn;
        Age = age;
    }
    //public Person() // DEFAULT CONSTRUCTOR
    //{
    //}


    //public int GetAge()
    //{
    //    return Age;
    //}
    //public void SetAge(int newAge)
    //{
    //    if (newAge < 18 || newAge > 150)
    //    {
    //        throw new ArgumentException("Invalid new age");
    //    }
    //    else 
    //        Age = newAge;
    //}

//    public string Name { get; set; }
//    public int Age { get; set; }
}