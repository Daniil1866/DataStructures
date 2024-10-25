internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Stack<string> stack = new Stack<string>();

        //A LIFO data structure, useful in cases where you need to do undo/redo actions

        stack.Push("item1");
        stack.Push("item2");
        stack.Push("item3");
        stack.Push("item4");
        stack.Push("item5");

        while (stack.Count > 0)
        {
            System.Console.WriteLine(stack.Pop());
        }
    }
}