public sealed class SingletonPatternR1{
	private static SingletonPatternR1 _instance = null;
	private SingletonPatternR1(){}
	public static SingletonPatternR1 Instance{
		get{
			lock(_instance){
				_instance = _instance ?? new SingletonPatternR1();
				return _instance;
			}
		}
	}
}
