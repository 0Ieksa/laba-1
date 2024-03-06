class Obj
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Obj> objects = new List<Obj>
        {
            new Obj { Id = 1, Name = "Windranger" },
            new Obj { Id = 2, Name = "Roshan" },
            new Obj { Id = 3, Name = "Pudge" }
        };

        Console.WriteLine("Введіть значення Id для пошуку:");
        int targetId = int.Parse(Console.ReadLine());

        Obj FindObject = FindObjectById(objects, targetId);
        if (FindObject != null)
        {
            Console.WriteLine($"Знайдений об'єкт: {FindObject.Id} {FindObject.Name}");
        }
        else
        {
            Console.WriteLine("Об'єкт не знайдено.");
        }

        Console.ReadKey();
    }

    static Obj FindObjectById(List<Obj> objects, int id)
    {
        foreach (Obj obj in objects)
        {
            if (obj.Id == id)
            {
                return obj;
            }
        }
        return null; 
    }
}