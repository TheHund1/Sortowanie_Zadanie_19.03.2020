using System;
using System.Collections.Generic;
using System.Text;

namespace Sortowanie_Zadanie_19._03._2020
{
	class Bucket
	{
		public static int[] BucketSort(int[] data)
		{
			int minValue = data[0];
			int maxValue = data[0];

			for (int i = 1; i < data.Length; i++)
			{
				if (data[i] > maxValue)
					maxValue = data[i];
				if (data[i] < minValue)
					minValue = data[i];
			}

			List<int>[] bucket = new List<int>[maxValue - minValue + 1];

			for (int i = 0; i < bucket.Length; i++)
			{
				bucket[i] = new List<int>();
			}

			for (int i = 0; i < data.Length; i++)
			{
				bucket[data[i] - minValue].Add(data[i]);
			}

			int k = 0;
			for (int i = 0; i < bucket.Length; i++)
			{
				if (bucket[i].Count > 0)
				{
					for (int j = 0; j < bucket[i].Count; j++)
					{
						//data[k] = bucket[i][j];

						Console.WriteLine("[{0}]->Bucket[{1}]", data[k] = bucket[i][j], (data[k] = bucket[i][j]) - 1);
						k++;
					}
				}

			}
			return data;
		}
	}
}
