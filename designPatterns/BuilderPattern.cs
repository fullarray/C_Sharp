public interface IBuilder{
	string RunBuilderTaskOne();
	string RunBuilderTaskTwo();
}
public class BuilderOne : IBuilder{
	#region IBuilder Members
	
	public string RunBuilderTaskOne(){
		throw new ApplicationException("Task One");
	}
	
	public string RunBuilderTaskTwo(){
		throw new ApplicationException("Task Two");
	}
	
	#endregion
}
public class BuilderTwo : IBuilder{
	#region IBuilder Members
	
	public string RunBuilderTaskOne(){
		return "Task 3";
	}
	
	public string RunBuilderTaskTwo(){
		return "Task 4";
	}
	
	#endregion
}
public class Director{
	public IBuilder CreateBuilder(int type){
		IBuilder builder = null;
		if(type == 1){
			builder = new BuilderOne();
		}else{
			builder = new BuilderTwo();
		}
		builder.RunBuilderTaskOne();
		builder.RunBuilderTaskTwo();
		return builder;
	}	
}
