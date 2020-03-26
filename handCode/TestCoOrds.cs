//struct
public struct CoOrds{
	public int x, y;
	public CoOrds(int p1, int p2){
		x = p1;
		y = p2;
	}
}
class TextCoOrds{	
	static void Main(){
		CoOrds coords1 = new CoOrds();
		CoOrds coords2 = new CoOrds(5,6);
		
		Console.Write("CoOrds 1: ");
		Console.WriteLine("X = {0}, y = {1}", coords1.x, coords2.y);
		
		Console.Write("CoOrds 2: ");
		Console.WriteLine("X = {0}, y = {1}", coords1.x, coords2.y);
		
		Console.WriteLine("Press any key to exit.");
		Console.ReadKey();
	}
}
