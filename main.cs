using System;

class Program {
  public static void Main (string[] args) {
    double newPrice;   
    int newQuantity = 0; 
    int choice;
    StockItem milk = new StockItem("Milk", 3.60, 30);
    StockItem bread = new StockItem("Bread", 1.98, 30);
    bool menu = true;
    while(menu){
    Console.WriteLine("1. Sold One Milk");
    Console.WriteLine("2. Sold One Bread");
    Console.WriteLine("3. Change price of Milk");
    Console.WriteLine("4. Change price of Bread");
    Console.WriteLine("5. Add Milk to Inventory");
    Console.WriteLine("6. Add Bread to Inventory");
    Console.WriteLine("7. See Inventory");
    Console.WriteLine("8. Quit");
    //convert to int with Tostring or something 
    choice = Convert.ToInt32(Console.ReadLine());
    switch(choice){
      case 1:
        milk.lowerQuantity();
        break;
      case 2: 
        bread.lowerQuantity();
        break;
      case 3: 
        Console.Write("Enter new Price for Milk: ");
        newPrice = Convert.ToDouble(Console.ReadLine());
        milk.setPrice(newPrice);
        break;
      case 4:
        Console.Write("Enter new Price for Bread: ");
        newPrice = Convert.ToDouble(Console.ReadLine());
        bread.setPrice(newPrice);
        break;
      case 5:
        Console.Write("Amount of milk(s) to add: ");
        newQuantity = Convert.ToInt32(Console.ReadLine());
        milk.raiseQuantity(newQuantity);
        break;
      case 6:
        Console.Write("Amount of bread(s) to add: ");
        newQuantity = Convert.ToInt32(Console.ReadLine());
        bread.raiseQuantity(newQuantity);
        break;
      case 7:
        Console.WriteLine(milk);
        Console.WriteLine(bread);
        break;
      case 8:
        menu = false;
        break;
      }
    }
  }
}
class StockItem { 
  static private int next_ID = 0;
  private string description;
  private int id;
  private double price;
  private int quantity;
  public StockItem(){
    this.description = null;
    this.id = 0;
    this.price = 0;
    this.quantity = 0;
  }
  public StockItem(string Description, double Price, int Quant){
    description = Description;
    this.id = next_ID;
    this.price = Price;
    this.quantity = Quant;
    next_ID++;
  }
  public string getDescription(){
    return description;
  }
  public int getID(){
    return id;
  }
  public double getPrice(){
    return price;
  }
  public int getQuantity(){
    return quantity;
  }
  public void setPrice(double newPrice){
    if(newPrice < 0){
      Console.WriteLine("Error, Price cannot be below 0");
    }
    else{
    price = newPrice;
    }
  }
  public void lowerQuantity(){
    if(quantity < 0){
      Console.WriteLine("Error, Quantity cannot be below 0");
    }
    else{
    quantity--;
    }
  }
public void raiseQuantity(int newQuantity){
  quantity = quantity + newQuantity;
}
public override string ToString(){
  return "Item: " + description + ", Price: " + price + ", Quantity: " + quantity + ", ID #: " + id;
  }
}