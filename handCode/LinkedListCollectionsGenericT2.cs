using System;
using System.Collections;
using System.Collections.Generic;

public class LinkedListCollectionsGenericT2{
	public static void main(){
		LinkedList<String> theorems = new LinkedList<String>();
		theorems.AddLast("Lagrange Interpolation Method For bivariate Polys");
		theorems.AddLast("Threshold Secret Sharing");
		theorems.AddLast("Secure Multiparty Computation");
		theorems.AddLast("Verifiable Secret Sharing");
		theorems.AddLast("Generalized Secret Sharing");
		if(theorems.Count > 0){
			Console.WriteLine("Theorem {0} is first.", theorems.First.Value);
			Console.WriteLine("Theorem {0} is last.", theorems.Last.Value);
			Console.WriteLine("Theorems list: ");
			foreach(String s in theorems){
				Console.WriteLine(" {0}", s);
			}
		}else{
			Console.WriteLine("No theorems found. ");
		}
	}
}
