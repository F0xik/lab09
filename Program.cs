Console.WriteLine("Введите количество вершин:");
int vector = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество ребер:");
int top = Convert.ToInt32(Console.ReadLine());
Dictionary <int, List<int>> dictionary = new Dictionary<int, List<int>>();
for (int i = 1; i < vector + 1; i++) { dictionary.Add(i, new List<int>()); }
Console.WriteLine("Соедините вершины через ENTER");
for(int i = 0; i < top; i++)
{
    int top1 = Convert.ToInt32(Console.ReadLine());; int top2 = Convert.ToInt32(Console.ReadLine());
    dictionary[top1].Add(top2);
    dictionary[top2].Add(top1);
}
foreach (int consul in dictionary.Keys)
{ Console.WriteLine($"{consul}:" + String.Join(" ", dictionary[consul])); }

