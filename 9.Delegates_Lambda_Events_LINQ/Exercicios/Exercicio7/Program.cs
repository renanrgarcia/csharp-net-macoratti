List<Planet> planets = new()
{
    new Planet("Mercury", 4879, 3.3e23),
    new Planet("Venus", 12104, 4.87e24),
    new Planet("Earth", 12756, 5.97e24),
    new Planet("Mars", 6792, 6.42e23),
    new Planet("Jupiter", 142984, 1.90e27),
    new Planet("Saturn", 120536, 5.68e26),
    new Planet("Uranus", 51118, 8.68e25),
    new Planet("Neptune", 49528, 1.02e26)
};

Predicate<Planet> predicate = p => p.Diameter > 10000 && p.Mass > 1e24;

List<Planet> filteredPlanets = planets.FindAll(predicate);

foreach (var planet in filteredPlanets)
{
    Console.WriteLine(planet);
}
// Output: 
// Venus - Diameter: 12104 km, Mass: 4.87e+24 kg
// Earth - Diameter: 12756 km, Mass: 5.97e+24 kg
// Jupiter - Diameter: 142984 km, Mass: 1.9e+27 kg


class Planet
{
    public string Name { get; set; }
    public int Diameter { get; set; }
    public double Mass { get; set; }
    public Planet(string name, int diameter, double mass)
    {
        Name = name;
        Diameter = diameter;
        Mass = mass;
    }
    public override string ToString()
    {
        return $"{Name} - Diameter: {Diameter} km, Mass: {Mass} kg";
    }
}