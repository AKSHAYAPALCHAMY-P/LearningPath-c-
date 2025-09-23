using System;using System.Runtime.InteropServices;

namespace Generics;

class SomeCLass()
{
	public void GenericMethod<T1, T2>(T1 Param1, T2 Param2)
	{
		Console.WriteLine($"Parameter t1 Type{typeof(T1)}:Parameter T2 type:{typeof(T2)}");
		Console.WriteLine($"Parameter1 : {Param1} : Parameter 2 :{Param2}");
	}
}

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("generic method Example in c#");
		SomeCLass s = new SomeCLass();
		s.GenericMethod<int,int>(10,20);
		s.GenericMethod<double,string>(10.5,"Hello");
		s.GenericMethod<string,float>("Akshaya",20.5f);
		Console.ReadLine();
	}
}
