using System;

namespace GenericsDemo
{
	class MyGenericClass<T>
	{
		private T GenericMemberVariable; //Fields

		public MyGenericClass(T Value) //Constructors
		{
			GenericMemberVariable = Value;
		}

		public T GenericMethod(T GenericParameter) //Method
		{
			Console.WriteLine($"Parameter type: {typeof(T).ToString()}, Value: {GenericParameter}");
			Console.WriteLine($"Return type: {typeof(T).ToString()}, Value: {GenericMemberVariable}");
			return GenericMemberVariable;
		}

		public T GenericProperty { get; set; }
	}

	namespace GenericsDemo
	{
		class Program
		{
			static void Main()
			{
				//MyGenericClass<int> integerGenericClass = new MyGenericClass<int>(10);
				//int val = integerGenericClass.GenericMethod(200);
				//Console.WriteLine(val);
				//Console.ReadKey();

				MyGenericClass<string> stringGenericClass = new MyGenericClass<string>("Hello World");
				stringGenericClass.GenericProperty = "This is a gemeric propertyexample";
				string Result = stringGenericClass.GenericMethod("Generic Parameter");
				Console.WriteLine(Result);
				Console.ReadKey();
			}
		}
	}
}
