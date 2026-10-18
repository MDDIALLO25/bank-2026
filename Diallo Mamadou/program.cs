var person = new Person
{
    FirstName = "Mamadou",
    LastName = "Diallo",
    BirthDate = new DateTime(1990, 1, 1)
};

Console.WriteLine($"{person.FirstName} {person.LastName}, né le {person.BirthDate:dd/MM/yyyy}");