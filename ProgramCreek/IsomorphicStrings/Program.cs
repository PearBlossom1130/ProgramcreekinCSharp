using System.Collections.Generic;

namespace IsomorphicStrings
{
	class Program
	{
		static void Main(string[] args)
		{
		    var s1 = "Tee";
		    var s2 = "Fo1";

		    var b = IsIsomorphic(s1, s2);

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
			    if (dic.ContainsKey(c))
			    {
			        if (dic[c] != s2[i]) return false;
			    }
			    else
			    {
			        dic.Add(c, s2[i]);
			    }
			    i++;
			}

			return true;
		}
	}
}
