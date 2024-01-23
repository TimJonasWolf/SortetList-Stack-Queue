
/*

SortedList<int, string> liste = new SortedList<int, string>();

liste.Add(3, "Ironman");
liste.Add(2, "Spiderman");
liste.Add(1, "Batman");
liste.Add(4, "ssio");
liste.Add(5, "Zoro");

foreach(KeyValuePair<int,string> x in liste)   //KeyValuePair<int,string> oder var
{
	Console.WriteLine($" Schüler : {x.Key}ter {x.Value}");
}




Console.ReadKey();
*/

/*
SortedList<string, string> liste = new SortedList<string, string>();

liste.Add("H", "Ironman");
liste.Add("A", "Spiderman");
liste.Add("G", "Batman");
liste.Add("Z", "ssio");
liste.Add("F", "Zoro");

foreach (KeyValuePair<string, string> x in liste)   //KeyValuePair<int,string> oder var
{
	Console.WriteLine($" Schüler : {x.Key}:  {x.Value}");
}

Console.ReadKey();

*/

/*

SortedList<double, string> liste = new SortedList<double, string>();

for(int i = 1; i <= 5; i++)
{
	Console.Write($"\nGeben sie die {i}te Namen ein : ");

	string name = Console.ReadLine();

	Console.Write($"\nGeben sie die {i}te grösse ein : ");
	double gr = Convert.ToDouble(Console.ReadLine());

	liste.Add(gr, name);
}

Console.WriteLine();

foreach(var x in liste)
{
	Console.WriteLine($"\n{x.Key}  {x.Value}");
}

Console.ReadKey();

*/

/*
// Pusch= setze einen drauf, Pop= entferne einen, Peek= Sehe welche (bei Pop sehe ich auch welche das entfernt wird)

Stack<string> karten = new Stack<string>();
karten.Push("Herz 2");
karten.Push("Karo 3");
karten.Push("Pik 10");
karten.Push("Pik 5");
karten.Push("Kreuz Dame");
karten.Push("Pik 7");
karten.Push("Karo 2");

Console.WriteLine($"Oben steht: {karten.Pop()}");

Console.WriteLine($"Oben steht: {karten.Peek()}");

foreach(var x in karten)
{
	Console.WriteLine(x);
}

Console.ReadKey();

*/

/*

Stack<string> karten = new Stack<string>();

karten.Push("Herz 2");
karten.Push("Karo 3");
karten.Push("Pik 10");
karten.Push("Pik 5");
karten.Push("Kreuz Dame");
karten.Push("Pik 7");
karten.Push("Karo 2");

Console.WriteLine($"Oben steht: {karten.Pop()}");

Console.WriteLine($"Oben steht: {karten.Peek()}");

foreach (var x in karten)
{
	Console.WriteLine(x);

	if(x == "Pik 10")
	{
		break;
	}
}


Console.ReadKey();

*/

Queue<string> queue = new Queue<string>();

queue.Enqueue("Batman");
queue.Enqueue("Ironman");
queue.Enqueue("Spiderman");
queue.Enqueue("Zoro");
queue.Enqueue("Ssio");

Console.WriteLine(queue.Peek());
queue.Dequeue();
Console.WriteLine("------------------------------");
foreach(var x in queue)
{
	Console.WriteLine(x);
}

Console.WriteLine(queue.Peek());




Console.ReadKey();