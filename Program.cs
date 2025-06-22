public class ListNode
{
    public int Val;
    public ListNode? Next;
    public ListNode(int val) => Val = val;
}

class Program
{
    static ListNode? ReverseList(ListNode? head)
    {
        ListNode? prev = null;
        while (head != null)
        {
            var next = head.Next;
            head.Next = prev;
            prev = head;
            head = next;
        }
        return prev;
    }

    static void PrintList(ListNode? node)
    {
        while (node != null)
        {
            Console.Write(node.Val + " ");
            node = node.Next;
        }
        Console.WriteLine();
    }

    static void Main()
    {
        var head = new ListNode(1)
        {
            Next = new ListNode(2)
            {
                Next = new ListNode(3)
            }
        };
        var reversed = ReverseList(head);
        PrintList(reversed); // Output: 3 2 1
    }
}
