using System;

using System.Collections.Generic;

public class DictionaryLists{
	public static void main(){
		Dictionary<string, string> openWith = new Dictionary<string, string>();
		openWith.Add("txt", "notepad.exe");
		openWith.Add("png", "paint.exe");
		openWith.Add("docx", "word.exe");
		openWith.Add("xlsx", "excel.exe");
		openWith.Add("pptx", "powerpoint.exe");
		
		try{
			openWith.Add("txt", "winword.exe");
		}catch(ArgumentException){
			Console.WriteLine("A key = \"txt\" already exists.");
		}
		
		Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);
		openWith["rtf"] = "winword.exe";
		Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);
		
		openWith["doc"] = "winword.exe";
		
		try{
			Console.WriteLine("For key = \"tif\", value = {0}.");
		}catch(KeyNotFoundException){
			Console.WriteLine("Key = \"tif\" is not found.");
		}
		
		String value = "";
		if(openWith.TryGetValue("tif", out value)){
			Console.WriteLine("For key = \"tif\", value = {0}.", value);
		}else{
			Console.WriteLine("Key = \"tif\" is not found.");
		}
		
		if(!openWith.ContainsKey("ht")){
			openWith.Add("ht", "hypertrm.exe");
			Console.WriteLine("Value added for key = \"ht\": {0}.", openWith["ht"]);
		}
		
		Console.WriteLine();
		foreach(keyValuePair<string, string> kvp in openWith){
			Console.WriteLine("Key = {0}, value = {1}", kvp.Key, kvp.Value);
		}
		
		Dictionary<string, string>.ValueCollection valueCol1 = openWith.Values;
		
		Console.WriteLine();
		foreach(string s in valueCol1){
			Console.WriteLine("Value = {0}.", s);
		}
		
		Dictionary<string, string>.KeyCollection keyCol1 = openWith.keys;
		
		Console.WriteLine();
		foreach(string s in keyCol1){
			Console.WriteLine("Key = {0}.", s);
		}
		
		Console.WriteLine("\nRemove(\"doc\")");
		openWith.Remove("doc");
		
		if(!openWith.ContainsKey("doc")){
			Console.WriteLine("Key \"doc\" is not found.");
		}
	}
}
