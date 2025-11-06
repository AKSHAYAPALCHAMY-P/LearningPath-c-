//namespace EasyPronounciation
//{
//	public class EasyPronounciationWord
//	{
//		#region Publics
//		public static void Main(string[] args)
//		{
//			Console.WriteLine("Enter the testcases you want");
//			bool bTestcase = int.TryParse(Console.ReadLine(), out int nTest);

//			for(int i = 0; i < nTest; i++)
//			{
//				Console.WriteLine("Enter the input string");
//				string strInputString = Console.ReadLine().ToLower();

//				int nConsonantsCount = 0;

//				bool IsHard = false;

//				foreach(char c in strInputString)
//				{
//					if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
//					{
//						nConsonantsCount = 0;
//					}

//					else
//					{
//						nConsonantsCount++;

//						if(nConsonantsCount >= 4)
//						{
//							IsHard = true;
//							break;
//						}
//					}
//				}

//				if(IsHard)
//				{
//					Console.WriteLine("NO");
//				}
//				else
//				{
//					Console.WriteLine("YES");
//				}
//			}
//		}
//		#endregion
//	}
//}