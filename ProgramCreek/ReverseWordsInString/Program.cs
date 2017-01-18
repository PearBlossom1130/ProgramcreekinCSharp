namespace ReverseWordsInString
{
	using System.Text;

	class Program
	{
		static void Main(string[] args)
		{
			var sentence = "Hello world today";

			var reversedWords = ReverseWordsInString(sentence);
			ReverseWordsInString(ref reversedWords);
		}

		public static string ReverseWordsInString(string sentence)
		{
			var words = sentence.Split(' ');

			int j = words.Length - 1;
			int i = 0;
			while (i < j)
			{
				var temp = words[i];
				words[i++] = words[j];
				words[j--] = temp;
			}

			StringBuilder newSentence = new StringBuilder();
			foreach (var word in words)
			{
				newSentence.Append(word);
				newSentence.Append(" ");
			}

			return newSentence.ToString().TrimEnd();
		}


		public static void ReverseWordsInString(ref string sentence)
		{
			var words = sentence.Split(' ');

			int j = words.Length - 1;
			int i = 0;
			while (i < j)
			{
				var temp = words[i];
				words[i++] = words[j];
				words[j--] = temp;
			}

			StringBuilder newSentence = new StringBuilder();
			foreach (var word in words)
			{
				newSentence.Append(word);
				newSentence.Append(" ");
			}

			sentence = newSentence.ToString().TrimEnd();
		}

	}
}
