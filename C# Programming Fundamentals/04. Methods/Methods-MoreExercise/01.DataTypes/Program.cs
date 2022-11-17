using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
			string inputType = Console.ReadLine(); //"int", "real" or "string"

			if (inputType == "int")
			{
				int valueToModify = int.Parse(Console.ReadLine());
				ModifyInput(valueToModify);
			}
			else if (inputType == "real")
			{
				double valueToModify = double.Parse(Console.ReadLine());
				ModifyInput(valueToModify);
			}
			else if (inputType == "string")
			{
				string valueToModify = Console.ReadLine();
				ModifyInput(valueToModify);
			}
		}

		static void ModifyInput(int valueToModify)
		{
			Console.WriteLine(valueToModify * 2);
		}

		static void ModifyInput(double valueToModify)
		{
			Console.WriteLine(string.Format("{0:0.00}", valueToModify * 1.5));
		}

		static void ModifyInput(string valueToModify)
		{
			Console.WriteLine("${0}$", valueToModify);
		}
	}
}
