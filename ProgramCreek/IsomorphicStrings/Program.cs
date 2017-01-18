using System.Collections.Generic;

namespace IsomorphicStrings
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		public static bool IsIsomorphic(string s1, string s2)
		{
			if (s1 == null && s2 == null) return true;
			if (s1 != null && s2 == null) return false;
			if (s1 == null && s2 != null) return false;
			if (s1.Length != s2.Length) return false;

			var dic = new Dictionary<char, char>();

			int i = 0;
			foreach (var c in s1)
			{
				if (dic.Keys(c))
			}



			return false;
		}
	}
}
