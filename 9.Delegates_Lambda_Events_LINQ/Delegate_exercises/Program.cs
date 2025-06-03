var people = Person.GetPeople();

// Print all names and ages
Action<Person> printNameAndAge = person => Console.WriteLine($"{person.Name} ({person.Age})");
people.ForEach(printNameAndAge);
// Output: All people:
// Alice (20)
// Bob (18)
// Charlie (25)
// Diana (17)
// Eve (15)

// Filter age > 18
Predicate<Person> isAdult = person => person.Age > 18;
Console.WriteLine("\nAdults:");
people.FindAll(isAdult).ForEach(printNameAndAge);
// Output: Adults:
// Alice (20)
// Charlie (25)

// Name and age of the older person
Func<Person, int> getAge = person => person.Age ?? 0;
// int maxAge = people.Max(getAge);
// Person? oldestPerson = people.FirstOrDefault(person => person.Age == maxAge);
var oldestPerson = people.MaxBy(getAge);
printNameAndAge(oldestPerson!);
// Output: Oldest person:
// Charlie (25)

Console.ReadKey();

class Person(string? name, int? age)
{
    public string? Name { get; set; } = name;
    public int? Age { get; set; } = age;

    public static List<Person> GetPeople()
    {
        List<Person> people = new List<Person>()
        {
            new Person("Alice", 20),
            new Person("Bob", 18),
            new Person("Charlie", 25),
            new Person("Diana", 17),
            new Person("Eve", 15)
        };

        return people;
    }
}

