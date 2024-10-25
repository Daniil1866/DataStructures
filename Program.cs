internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Queue<string> queue = new Queue<string>();

        // FIFO data structure, areas of use: printer buffer, keyboard buffer, any data that waits to be processed

        queue.Enqueue("item1");
        queue.Enqueue("item2");
        queue.Enqueue("item3");

        while (queue.Count > 1)
        {
            System.Console.WriteLine(queue.Dequeue());
        }
        
        queue.Peek();
        
        System.Console.WriteLine(queue.Contains("item3"));
    }
}