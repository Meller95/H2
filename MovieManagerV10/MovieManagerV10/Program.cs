
Movie movieA = new Movie("Alien", "Ridley Scott", 112);
Movie movieB = new Movie("Inception", "Christopher Nolan", 162);
Movie movieC = new Movie("The Matrix", "The Wachowskis", 136);
Movie movieD = new Movie("The Shawshank Redemption", "Frank Darabont", 142);

Console.WriteLine("Before calls of Watch():");
Console.WriteLine($"{movieA.Title}, by {movieA.Director}, " +
                  $"watched it {movieA.NoOfViews} time(s)");
Console.WriteLine($"{movieB.Title}, by {movieB.Director}, " +
                  $"watched it {movieB.NoOfViews} time(s)");
Console.WriteLine($"{movieC.Title}, by {movieC.Director}, " +
                  $"watched it {movieC.NoOfViews}");

movieA.Watch();
movieA.Watch();
movieB.Watch();
movieC.Watch();

Console.WriteLine("After calls of Watch():");
Console.WriteLine($"{movieA.Title}, by {movieA.Director}, " +
                  $"watched it {movieA.NoOfViews} time(s)");
Console.WriteLine($"{movieB.Title}, by {movieB.Director}, " +
                  $"watched it {movieB.NoOfViews} time(s)");
Console.WriteLine($"{movieC.Title}, by {movieC.Director}, " +
                  $"watched it {movieB.NoOfViews} time(s)");
