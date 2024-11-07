namespace Variable_Exercise_1;

class Program
{
    static void Main(string[] args)
    {
        int myCatAge = 4;
        string catName = "Nifa";
        bool catIsFemale = true;
        char catGender = 'F';
        double catWeight = 12;
        decimal catPrice = 700.00M;
        Console.WriteLine($"My cat's name is {catName}, She is {myCatAge} years old. We had to take her to the vet and get her weight which was {catWeight} pounds.");
        Console.WriteLine($"Is my cat female? {catIsFemale}, so on the chart I had to write {catGender}.");
        Console.WriteLine($"She needed a dental cleaning and teeth pulled which cost {catPrice} dollars.");
    }
}