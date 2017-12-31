class CArray{
	private int [] arr;
	private int upper;
	private int numElements;
	public CArray(int size){
		arr = new int[size];
		upper = size-1;
		numElements = 0;
	}
	
	public void Insert(int item){
		arr[numElements] = item;
		numElements++;
	}
	
	public void DisplayElements(){
		for(int i = 0; i <= upper; i++){
			Console.Write(arr[i] + " ")
		}
	}
	
	public void Clear(){
		for(int i = 0; i <= upper; i++){
			arr[i] = 0;
		}
		numElements = 0;
	}
	
	static void Main(){
		CArray nums = new CArray();
		for(int i = 0; i <= 40; i++){
			nums.Insert(i);
		}
		nums.DisplayElements():
	}
}