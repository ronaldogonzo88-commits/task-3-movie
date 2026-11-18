using System;
class Movie
{
    private string title;
    private int year, runtime;
    public void Set(string t, int y,int r)
    {
        title = t;
        year = y;
        runtime = r;
    }
    public string Gettitle()
    {
        return title;
    }
    public int GetRuntime()
    {
        return runtime;
    }
}
class Program
{
    static void Main()
    {
        Movie[] movies = new Movie[4];
        for (int i = 0; i < 4; i++)
        {
            movies[i] = new Movie();

            Console.WriteLine("Enter the title: ");
            string t = Console.ReadLine();

            Console.WriteLine("Enter the year: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the runtime: ");
            int r = int.Parse(Console.ReadLine());
            movies[i].Set(t, y, r);
        }

        Console.WriteLine("Enter minimum runtime: ");
        int min = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter maximum runtime: ");
        int max = int.Parse(Console.ReadLine());

        for (int i = 0; i < 4; i++)
        {
            if (movies[i].GetRuntime() >= min && movies[i].GetRuntime() <= max)
            {
                Console.WriteLine("Movie: " + movies[i].Gettitle());
                break;
            }
        }
    }
}
