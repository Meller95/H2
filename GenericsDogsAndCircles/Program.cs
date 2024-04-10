
#region Dog objects
using GenericsDogsAndCircles;

Dog dog1 = new Dog("King", 70, 55);
Dog dog2 = new Dog("Spot", 30, 10);
Dog dog3 = new Dog("Rufus", 80, 40);
#endregion

#region Circle objects
Circle c1 = new Circle(10, 2, 3);
Circle c2 = new Circle(15, 6, 0);
Circle c3 = new Circle(8, 12, 7);
#endregion

#region ObjectComparer test
BetterObjectComparer<Dog> Dogcomparer = new BetterObjectComparer<Dog>();
BetterObjectComparer<Circle> Circlecomparer = new BetterObjectComparer<Circle>();
Console.WriteLine(Dogcomparer.Largest(dog1, dog2, dog3));
Console.WriteLine(Circlecomparer.Largest(c1, c2, c3));
#endregion


EvenBetterObjectComparer comparer = new EvenBetterObjectComparer();

Dog largestDog = comparer.Largest(dog1, dog2, dog3, new DogCompareByHeight());
Circle largestCircle = comparer.Largest(c1, c2, c3, new CircleCompareByX());

Console.WriteLine($"{largestDog.Name} has a height of {largestDog.Height}");
Console.WriteLine($"{largestCircle.Radius} is the largest circle's radius");