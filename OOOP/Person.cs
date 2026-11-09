

class Person
{
    public string name = "Не известно";
    public int age;
    public Person() { name = "Незивестно"; age = 18; }//конструктор 1
    public Person(string n) { name = n; age = 18; }//конструктор 2
    public Person(string n, int a) { name = n; age = a; }//конструктор 3
    public Person(int a, string n) { age = 15; name = "4 конструктор"; }//4 конструктор есстесвена


    public void Print()
    {
        Console.WriteLine($"Имя:{name}, Возраст:{age}");
    }

}

