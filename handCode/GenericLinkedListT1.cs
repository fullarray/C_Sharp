using System;

namespace GenericLinkedListT1{
	public class Program{
		static void main(string[] arg){
			GenericList<int> numberList = GenericList<int>();
			numberList.addNode(12);
			numberList.addNode(34);
			numberList.addNode(7);
			numberList.addNode(58);
			int intVal = numberList.GetLast();
			Console.WriteLine(intVal);
			
			GenericList<int> numberList2 = new GenericList<int>();
			intVal = numberList2.getLast();
			Console.WriteLine(intVal);
			
			GenericList<string> wordList = new GenericList<string>();
			wordList.addNode("One");
			wordList.addNode("Three");
			string sVal = wordList.getLast();
			Console.WriteLine(intVal);
			
			GenericList<string> wordList2 = new GenericList<string>();
			sVal = wordList2.getLast();
			Console.WriteLine(sVal);
		}
	}
	public class GenericList<T>{
		private class Node{
			public Node Next;
			public T Data;
		}
		
		private Node head = null;
		
		public void addNode(T t){
			Node newNode = new Node();
			newNode.Next = head;
			newNode.Data = t;
			head = newNode;
		}
		
		public T getLast(){
			T temp = default();
			
			Node current = head;
			while(current != null){
				temp = current.Data;
				current = current.Next;
			}
			return temp;
		}
	}
}
