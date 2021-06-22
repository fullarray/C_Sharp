public interface IFactoryOne{
	
	IPeople GetPeople();
	
}


public class FactoryOne : IFactoryOne{
	public IPeople GetPeople(){
		return new CountryPeople();
	}
}


public interface IFactoryTwo{
	IProduct GetProduct();
}

public class FactoryTwo : IFactoryTwo{
	public IProduct GetProduct(){
		return new IPhone();
	}
}

public abstract class AbstractFactories{
	public abstract IFactoryOne GetFactoryOne();
	public abstract IFactoryTwo GetFactoryTwo();
}

public class ConcreteFactory : AbstractFactories{
	public override IFactoryOne GetFactoryOne(){
		return new FactoryOne();
	}
	//new object
	public override IFactoryTwo GetFactoryTwo(){
		return new FactoryTwo();
	}
}
