
using System.Data;

int[] items = new int[5];

int search, find = 0;

for(int i=0;i<items.Length;i++)
{
	Console.Write("Enter "+(i+1)+" Item Values:");
	items[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Enter Search Value: ");
search = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < items.Length; i++)
{
	if (search == items[i])
	{
		find++;
	}
}

if(find>0)
{
	Console.WriteLine(find);
}
else
{
	Console.WriteLine("Nothing Found!");
}