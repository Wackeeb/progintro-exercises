/*namespace CustomerTest;

class Program
{
    static void Main(string[] args)
    {        
        Customer Customer_1 = new Customer("Steven",1001);
        Customer Customer_2 = new Customer("Lebron",1002,100.5);

        //Customer_1
        Console.WriteLine($"{Customer_1.Name}, ID: {Customer_1.Id} har {Customer_1.GetBalance()} kr. i banken før");
        Customer_1.Deposit(300);
        Console.WriteLine($"{Customer_1.Name}, ID: {Customer_1.Id} har {Customer_1.GetBalance()} kr. i banken efter depositum på +300 kr.");
        Customer_1.Withdraw(200);
        Console.WriteLine($"{Customer_1.Name}, ID: {Customer_1.Id} har {Customer_1.GetBalance()} kr. i banken efter hævning på -200 kr.");

        Console.WriteLine("");
        //Customer_2
        Console.WriteLine($"{Customer_2.Name}, ID:{Customer_2.Id} har {Customer_2.GetBalance()} kr. i banken før");
        Customer_2.Deposit(300);
        Console.WriteLine($"{Customer_2.Name}, ID: {Customer_2.Id} har {Customer_2.GetBalance()} kr. i banken efter depositum på +300 kr.");
        Customer_2.Withdraw(500);
        Console.WriteLine($"{Customer_2.Name}, ID: {Customer_2.Id} har {Customer_2.GetBalance()} kr. i banken efter forsøg af hævning på -500 kr.");
    }
}

class Customer
{
    public string Name;
    public int Id;
    public double Balance;

    public Customer(string name_value, int id_value){
        Name = name_value;
        Id = id_value;
        Balance = 0;
    }
    public Customer(string name_value, int id_value, double balance_value){
        Name = name_value;
        Id = id_value;
        Balance = balance_value;
    }
    public void Deposit(double amount){
        Balance += amount;
    }
    public void Withdraw(double amount){
        if (Balance >= amount){
            Balance -= amount;
        }
    }
    public double GetBalance(){
        return Balance;
    }
}
/*
namespace Name;

class Program
{
    static void Main(string[] args){
        for (int i = 0; i < 10; i++){
            new Kitten(i);
            }
        Console.WriteLine($"{Kitten.count}");
    }
}

class Kitten {
    double Cuteness;
    public static int count = 0;
    
    public Kitten(double cuteness){
        this.Cuteness = cuteness;
        count++;
    }
}*/
/*
namespace Name;

class Program
{
    static void Main(string[] args){
        for (long i = 3; i < 6; i++){
            DateTimeOffset offset = System.DateTimeOffset.FromUnixTimeMilliseconds((long)Math.Pow(10,i));
            DateTime time = offset.DateTime;
            Console.WriteLine(time);
        }
    }
}*/

/*namespace Name;

class Program
{
    static void Main(string[] args){
        Dog dog = new Dog();
        dog.Eat(); // udskriver nom nom
    }
}

class Animal
{
    public void Eat(){
        Console.WriteLine("Nom Nom");
    }
}

class Dog : Animal
{}*/

namespace Name;

class Program
{
    static void Main(string[] args){
        FoodItem[] food = new FoodItem[10];

        for (int i = 0; i < food.Length; i++){
            food[i] = new FoodItem($"Item {i}", 20.3 * i, DateTime.Now.AddDays(i));
        }
        foreach (FoodItem item in food){
            Console.WriteLine(item.ToString());
            }

        string[] materials = {"Amplifier","Guitar","Pick","Capo","Microphone"};
        NonFoodItem[] mats = new NonFoodItem[5];

        for (int i = 0; i < mats.Length; i++){
            mats[i] = new NonFoodItem($"Item {i}", 20.3 * i, new string[] {materials[i]});
        }
        foreach (NonFoodItem item in mats){
            Console.WriteLine(item.ToString());
        }
    }
}

class Item
{
    protected string name;
    protected double price;

    public Item(string name_value, double price_value){
        name = name_value;
        price = price_value;
    }

    public string GetName(){
        return name;
    }

    public double GetPrice(){
        return price;
    }
}

class FoodItem : Item {
    private DateTime expiresAt;

    public FoodItem(string name, double price, DateTime expireAt_value)
        : base(name, price)
    {
        expiresAt = expireAt_value;
    }
    
    public DateTime GetExpiresAt(){
        return  expiresAt;
    }

    public override string ToString(){
        return $"Food: {name}, price: {price:F2} kr., expires {expiresAt}";
    }
}

class NonFoodItem : Item{
    private string[] materials;

    public NonFoodItem(string name, double price, string[] materials_value)
        : base(name, price)
    {
        materials = materials_value;
    }

    public string[] GetMaterials(){
        return materials;
    }

    public override string ToString(){        
        return $"Material: {name}: {string.Join(", ", materials)}, price: {price:F2} kr.";
    }
}