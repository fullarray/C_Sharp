public class Node{
	public Node Next;
	public object Value;
}
public class LinkedList{
	private Node head;
	private Node current;
	public int count;
}
public LinkedList(){
	head = new Node();
	current = head;
}

public void addAtLast(object data){
	Node newNode = new Node();
	newNode.Value = data;
	current.Next = newNode;
	current = newNode;
	count++;
}

public void addAtStart(object data){
	Node newNode = new Node(){
		Value = data;
	}
	newNode.Next = head.Next;
	head.Next = newNode;
	count++;
}

public void removeFromStart(){
	if(count > 0){
		head.Next = head.Next.Next;
		count--;
	}else{
		Console.WriteLine("No element. ");
	}
}

public void printAllNode(){
	Console.Write("Head ->");
	Node curr = head;
	while(curr.Next != null){
		curr = curr.Next;
		Console.Write(curr.Value);
		Console.Write("->");
	}
	Console.Write("NULL");
}

class SinglyListImpT3{
	static void main(string[] args){
		LinkedList lnklist = new LinkedList();
		lnklist.printAllNode();
		Console.WriteLine();
		
		lnklist.addAtLast(84);
		lnklist.addAtLast(42);
		lnklist.addAtLast(294);
		lnklist.addAtLast(54);
		lnklist.printAllNode();
		Console.WriteLine();
		
		lnklist.addAtStart(10);
		lnklist.printAllNode();
		Console.WriteLine();
		
		lnklist.removeFromStart();
		lnklist.printAllNode();
		
		Console.ReadKey();		
	}
}
