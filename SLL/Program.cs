using System;

namespace SLL
{
  public class SllNode
  {
    public int Value;
    public SllNode Next;
    public SllNode(int value)
    {
      Value = value;
      Next = null;
    }
  }
  public class SinglyLinkedList
  {
    public SllNode Head;
    public SinglyLinkedList()
    {
      Head = null;
    }
    // SLL methods go here. As a starter, we will show you how to add a node to the list.
    public void Add(int value)
    {
      SllNode newNode = new SllNode(value);
      if (Head == null)
      {
        Head = newNode;
      }
      else
      {
        SllNode runner = Head;
        while (runner.Next != null)
        {
          runner = runner.Next;
        }
        runner.Next = newNode;
      }
    }
    public void Remove()
    {
        if (Head != null)
            {
                SllNode runner = Head; 
                while (runner.Next.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = null;
            }
    }
    public void PrintValues()
    {
      SllNode runner = Head;
      while (runner != null)
      {
          Console.WriteLine(runner.Value);
        runner = runner.Next;
      }
    }

    public SllNode Find(int value)
    {
      SllNode runner = Head;
      while (runner != null)
      {
        if (runner.Value != value)
            runner = runner.Next;
        else
            return runner;
      }
      Console.WriteLine("Not Found");
      return null;
    }
  }
    class Program
    {
        static void Main(string[] args)
        {
            SllNode one = new SllNode(1);
            SllNode two = new SllNode(2);
            SllNode three = new SllNode(3);
            SinglyLinkedList head = new SinglyLinkedList();
            head.Head = one;
            one.Next = two;
            two.Next = three;
            Console.WriteLine(head.Find(3).Value);
        }
    }
}
