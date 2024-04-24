using System;
using System.Collections.Generic;
using System.Linq;

public class Pet<T> where T : struct
{
	private List<T> petList;

	public Pet()
	{
		petList = new List<T>();
	}

	public void AddPet(T item)
	{
		petList.Add(item);
	}

	public T GetPet(int index)
	{
		if (index < 0 || index >= petList.Count)
		{
			throw new IndexOutOfRangeException("Index is out of range.");
		}

		return petList[index];
	}

	public List<T> GetSortedDescending()
	{
		List<T> sortedList = new List<T>(petList);
		sortedList.Sort();
		sortedList.Reverse();
		return sortedList;
	}
}

class Program
{
	static void Main(string[] args)
	{
		var petCollection = new Pet<int>();
		petCollection.AddPet(1);
		petCollection.AddPet(2);
		petCollection.AddPet(3);
		petCollection.AddPet(4);

		Console.WriteLine("Items in the original collection:");
		foreach (int item in petCollection.GetSortedDescending())
		{
			Console.WriteLine(item);
		}

		Console.WriteLine("\nPet at index 2: " + petCollection.GetPet(2));
	}
}
