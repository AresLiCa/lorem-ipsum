using System;
using System.Collections;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		
		
		Question q1 = new Question(new ArrayList(){"Download installation file of ASRP",
												   "Download vault registration key",
												   "Install ASRP on hyper-v host and register the server",
												   "Download the storage key",
												   "Install ASRP on 5 vms"
												  },"Replicate throgh Azure Site Recovery",3);
		
		
		
		
		
		
	}
}




public class Question{

	public ArrayList option_list;
	public string description;
	public int number_of_options;
	
	public Question(ArrayList _option_list,string _description, int _number_of_options){
		
		option_list = new ArrayList();
		
		option_list = _option_list;
		description = _description;
		number_of_options = _number_of_options;
		
		print();
	}


	public void print(){
		
		
		Console.WriteLine("Question: "+description+"\n"
						  +"Select: "+number_of_options+"\n"
						 +"Options: "+"\n");
		
		
		SortAlphabetLength alphaLen = new SortAlphabetLength(); 
		
		option_list.Sort(alphaLen);
		
		foreach (string o in option_list){
			Console.WriteLine(o);
		}
	
	}

}


public class SortAlphabetLength : System.Collections.IComparer { public int Compare(Object x, Object y) { if (x.ToString().Length == y.ToString().Length) return string.Compare(x.ToString(), y.ToString()); else if (x.ToString().Length > y.ToString().Length) return 1; else return -1; } }
