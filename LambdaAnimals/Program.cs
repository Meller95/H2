
Dog d1 = new Dog("King", 25);
Dog d2 = new Dog("Tiny", 95);
Dog d3 = new Dog("Rufus", 36);
Dog d4 = new Dog("Spot", 55);
Dog d5 = new Dog("Daisy", 8);
List<Dog> dogs = new List<Dog> { d1, d2, d3, d4, d5 };

// Print out all Dogs with a weight larger than 40 kg.

ConditionalPrint(dogs, dog => dog.Weight > 40);

// Print out all Dogs with a weight smaller than Rufus' weight.

ConditionalPrint(dogs, dog => dog.Weight < d3.Weight);

// Print out all Dogs with a name that contains an "i"

ConditionalPrint(dogs, dog => dog.Name.Contains("i"));

static void ConditionalPrint<T>(List<T> objects, Predicate<T> pred)
{
    Console.WriteLine();
    foreach (var item in objects.FindAll(pred))
    {
        Console.WriteLine(item);
    }
}


static void ConditionalPrint2<T>(List<T> objects, Predicate<T> pred1, Predicate<T> pred2)
{
    foreach (var item in objects.FindAll(item => pred1(item) && pred2(item)))
    {
        Console.WriteLine(item);
    }
}

ConditionalPrint2(dogs, dog => dog.Weight > d3.Weight, dog => dog.Name.Length > 3);

static void MultiConditionalPrint<T>(List<T> objects, List<Predicate<T>> conditions)
{
    foreach (var item in objects.Where(item => conditions.All(cond => cond(item))))
    {
        Console.WriteLine(item);
    }
}

List<Predicate<Dog>> conditions = new List<Predicate<Dog>>
{
    dog => dog.Weight > d3.Weight,
    dog => dog.Name.Length > 3,
    dog => !dog.Name.StartsWith("D")
};

MultiConditionalPrint(dogs, conditions);