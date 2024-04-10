
using GenericRepository;

Repository<Car> carRepo = new Repository<Car>();
Repository<Employee> employeeRepo = new Repository<Employee>();
Repository<Computer> computerRepo = new Repository<Computer>();
Repository<Phone> phoneRepo = new Repository<Phone>();

Employee e1 = new Employee("Allan", 1962);
Employee e2 = new Employee("Bente", 1975);
Employee e3 = new Employee("Carlo", 1973);

employeeRepo.Add(e1);
employeeRepo.Add(e2);
employeeRepo.Add(e3);


Car c1 = new Car("AB 12 345", 80000);
Car c2 = new Car("CD 34 456", 65000);

carRepo.Add(c1);
carRepo.Add(c2);

Computer comp1 = new Computer("123456", "PC1");
Computer comp2 = new Computer("234567", "PC2");

computerRepo.Add(comp1);
computerRepo.Add(comp2);

Phone p1 = new Phone("12345678", "Samsung");
Phone p2 = new Phone("87654321", "iPhone");

phoneRepo.Add(p1);
phoneRepo.Add(p2);

carRepo.printAll();
Console.WriteLine("Car repository count: " + carRepo.Count);

employeeRepo.printAll();
Console.WriteLine("Employee repository count: " + employeeRepo.Count);

computerRepo.printAll();
Console.WriteLine("Computer repository count: " + computerRepo.Count);

phoneRepo.printAll();
Console.WriteLine("Phone repository count: " + phoneRepo.Count);