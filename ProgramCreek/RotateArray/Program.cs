using System;

namespace RotateArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] k = { 1, 2, 3, 4, 5, 6, 7 };

			//Rotate1(k, 13);
			//Rotate2(k, 13);
			Rotate3(k, 3);
		}

		// Space: O(n) Time: O(n)
		public static void Rotate1(int[] nums, int k)
		{
			if (k > nums.Length) k = k % nums.Length;

			var result = new int[nums.Length];

			for (var i = 0; i < k; i++)
			{
				result[i] = nums[nums.Length - k + i];
			}

			int j = 0;
			for (var i = k; i < nums.Length; i++)
			{
				result[i] = nums[j++];
			}

			Array.Copy(result, nums, nums.Length); // Must to return the results in nums array
		}

		//Space: O(1) Time:O(n*k)
		public static void Rotate2(int[] nums, int k)
		{
			if (nums == null || k < 0)
			{
				throw new ArgumentException();
			}

			if (k > nums.Length) k = k % nums.Length;

			for (var i = 0; i < k; i++)
			{
				for (var j = nums.Length - 1; j > 0; j--)
				{
					int temp = nums[j];
					nums[j] = nums[j - 1];
					nums[j - 1] = temp;
				}
			}
		}

		//Space: O(1) Time:O(n)
		public static void Rotate3(int[] nums, int k)
		{
			if (nums == null || nums.Length == 0 || k < 0)
				throw new ArgumentException();

			if (k > nums.Length) k = k % nums.Length;

			int a = nums.Length - k;

			Reverse(nums, 0, a - 1);
			Reverse(nums, a, nums.Length - 1);
			Reverse(nums, 0, nums.Length - 1);
		}

		private static void Reverse(int[] arr, int left, int right)
		{
			if (arr == null || arr.Length == 1) return;

			while (left < right)
			{
				int temp = arr[left];
				arr[left] = arr[right];
				arr[right] = temp;

				left++;
				right--;
			}
		}
	}
}
