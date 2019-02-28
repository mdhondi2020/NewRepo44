namespace CodeGuruProject
{
using System;
using System.Collections.Generic;
	public class First
	{

		public class cust {
			public int ID { get; set; }
			public string Name { get; set; }
			public int Sal { get; set; }
			
		}

		public abstract class MyFirstAbsClass{

			public abstract int Tset(int x, int y);
			public static   int  Test1() {

				int a=12, b=90;
				int total;
				return total = a + b;
			}
		}

		public class Imple : MyFirstAbsClass {

			public override int Tset(int a, int b)
			{
				return 10;
			}

			int res = Test1();
		}



		public static void Main(string[] args) {


			cust c1 = new cust() { ID = 101, Sal = 3000, Name = "Motilal" };
			cust c2 = new cust() { ID = 102, Sal = 5000, Name = "Shivalal" };
			cust c3 = new cust() { ID = 103, Sal = 7000, Name = "Amjt" };

			

			Dictionary<int, cust> custDictionary = new Dictionary<int, cust>();
			custDictionary.Add(c1.ID, c1);
			custDictionary.Add(c2.ID, c2);
			custDictionary.Add(c3.ID, c3);
			var custrecord = custDictionary[101];
			Console.WriteLine("Results{0},{1}", custrecord.Name,custrecord.Sal);

			foreach (KeyValuePair<int, cust> custkeyvalue in custDictionary) {

				Console.WriteLine("customer id = {0}", custkeyvalue.Key);
				var res				= custkeyvalue.Value;
				Console.WriteLine("Name = {0}, sal{1}", res.Name, res.Sal);
			

			}

			Console.ReadLine();

		}


	}
}
