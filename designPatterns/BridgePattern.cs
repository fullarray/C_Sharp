public interface IBridge{
	void functionOne();
	void functionTwo();
}
public class BridgeOne : IBridge{
	#regions IBridge Members
	public void functionOne(){
		throw new NotImplementedException();
	}
	
	public void functionTwo(){
		throw new NotImplementedException();
	}
	#endregion
}
public class BridgeTwo : IBridge{
	#region IBridge Members
	
	public void functionOne(){
		throw new NotImplementedException();
	}
	
	public void functionTwo(){
		throw new NotImplementedException();
	}
	#endregion
}

public interface IAbstractBridge{
	void callMethodOne();
	void callMethodTwo();
}

public class AbstractBridge : IAbstractBridge{
	public IBridge bridge;
	
	public AbstractBridge(IBridge bridge){
		this.bridge = bridge;
	}
	#region IAbstractBridge Members
	
	public void callMethodOne(){
		this.bridge.functionOne();
	}
	public void callMethodTwo(){
		this.bridge.functionTwo();
	}
	#endregion
}
