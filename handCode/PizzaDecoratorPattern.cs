public abstract class Pizza{
	public abstract double getPrice();
}
class ThickCrust : Pizza{
	private double p_Price = 250.0;
	public override double getPrice(){
		return p_Price;
	}
}
class ThinCrust : Pizza{
	private double p_Price = 200.0;
	
	public override double getPrice(){
		return p_Price;
	}
}
public class Decorator : Pizza{
	Pizza basePizza = null;
	
	protected double p_Price = 0.0;
	
	protected Decorator(Pizza obj){
		basePizza = obj;
	}
	public override double getPrice(){
		return p_Price + basePizza.getPrice();
	}
}

public class OnionPizzaDecorator{}

public class CheesePizzaDecorator{}

//Driver
class PizzaDecoratorPattern{
	static void Main(string[] args){
		ThickCrust thickCrust = new ThickCrust();
		PizzaPriceInfo(thickCrust);
		
		OnionPizzaDecorator onionPizza = new OnionPizzaDecorator(thickCrust);
		
		CheesePizzaDecorator cheesePizza = new CheesePizzaDecorator(onionPizza);
		PizzaPriceInfo(cheesePizza);
	}
	private static void pizzaPriceInfo(Pizza obj){
		Console.WriteLine();
	}
}
