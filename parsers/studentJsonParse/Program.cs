//Imports from web framework goes heres
using System;

namespace studentJsonParse{
	class Program{
		static void main(string[] args){
			var student1 = @"{""id"": 1, 
			                  ""firstname"": ""John"",
							  ""lastname"": ""Doe"", 
							  ""college"": ""Acme College"",
							  ""studentid"": ""vb3234455"" }";
			var student2 = @"{""id"": 2, 
			                  ""firstname"": ""Maria"",
							  ""lastname"": ""Morales"",
							  ""college"": ""Acme College"",
							  ""studentid"": ""vb000455"" }";
			var student4 = @"{""id"": 4, 
			                  ""firstname"": ""Valerius"",
							  ""lastname"": ""Roccy"",
							  ""college"": ""Acme College"",
							  ""studentid"": ""vb000451"" }";
			var student3 = @"{""id"": 3, 
			                  ""firstname"": ""Victor"",
							  ""lastname"": ""Olives"",
							  ""college"": ""Acme College"",
							  ""studentid"": ""vb004355"" }";
			
			var JSONObj = new JavaScriptSerializer().Deserialize<Dictionary<string, string>> (student1);
			console.WriteLine("Name: "+ JSONObj["firstname"] +" "+ JSONObj["lastname"] );
			console.WriteLine("College: "+ JSONObj["college"] +" ID: "+ JSONObj["studentid"]);

			var JSONObj1 = new JavaScriptSerializer().Deserialize<Dictionary<string, string>> (student2);
			console.WriteLine("Name: "+ JSONObj1["firstname"] +" "+ JSONObj1["lastname"] );
			console.WriteLine("College: "+ JSONObj1["college"] +" ID: "+ JSONObj1["studentid"] );

			var JSONObj2 = new JavaScriptSerializer().Deserialize<Dictionary<string, string>> (student3);
			console.WriteLine("Name: "+ JSONObj2["firstname"] +" "+ JSONObj2["lastname"] });
			console.WriteLine("College: "+ JSONObj2["college"] +" ID: "+ JSONObj2["studentid"] });			
			
		}
	}
}
