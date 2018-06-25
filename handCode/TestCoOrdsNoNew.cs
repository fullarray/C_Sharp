//declare CoOrds struct
public struct CoOrds{
	public int x, y;
	public CoOrds(int p1, int p2){
		x = p1;
		y = p2;
	}
}

class TestCoOrdsNoNew{
	static void Main(){
		CoOrds coords1;
		
		coords1.x = 15;
		coords1.y = 30;
		
		Console.Write("CoOrds 1: ");
		Console.WriteLine("X = {0}, y = {1}", coords1.x, coords1.y);
		
		Console.WriteLine("Press any key to exit.");
		Console.ReadKey();
	}
}
