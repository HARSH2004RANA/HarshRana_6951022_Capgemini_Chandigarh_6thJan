using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> ticketQueue = new Queue<string>();
            ticketQueue.Enqueue("Ticket 1: Login issue");
            ticketQueue.Enqueue("Ticket 2: Payment failed");
            ticketQueue.Enqueue("Ticket 3: App crash");

            Stack<string> undoStack = new Stack<string>();

            Console.WriteLine("Initial Ticket Queue:");
            DisplayQueue(ticketQueue);

            Console.WriteLine("\n--- Processing Tickets ---");

            string currentTicket = ticketQueue.Dequeue();
            Console.WriteLine($"\nProcessing: {currentTicket}");
            undoStack.Push("Opened ticket");
            undoStack.Push("Checked user details");
            undoStack.Push("Reset password");

            Console.WriteLine("Actions performed:");
            DisplayStack(undoStack);

            Console.WriteLine("\nUndo last action:");
            string undoneAction = undoStack.Pop();
            Console.WriteLine($"Undone: {undoneAction}");

            Console.WriteLine("Remaining actions:");
            DisplayStack(undoStack);

            currentTicket = ticketQueue.Dequeue();
            Console.WriteLine($"\nProcessing: {currentTicket}");
            undoStack.Clear();
            undoStack.Push("Opened ticket");
            undoStack.Push("Checked payment gateway");
            undoStack.Push("Restarted service");

            Console.WriteLine("Actions performed:");
            DisplayStack(undoStack);

            Console.WriteLine("\nUndo last action:");
            undoneAction = undoStack.Pop();
            Console.WriteLine($"Undone: {undoneAction}");

            currentTicket = ticketQueue.Dequeue();
            Console.WriteLine($"\nProcessing: {currentTicket}");
            undoStack.Clear();
            undoStack.Push("Opened ticket");
            undoStack.Push("Collected logs");
            undoStack.Push("Reported to dev team");

            Console.WriteLine("Actions performed:");
            DisplayStack(undoStack);

            Console.WriteLine("\nUndo last action:");
            undoneAction = undoStack.Pop();
            Console.WriteLine($"Undone: {undoneAction}");

            Console.WriteLine("\n--- Remaining Ticket Queue ---");
            DisplayQueue(ticketQueue);

            Console.ReadLine();
        }

        static void DisplayQueue(Queue<string> queue)
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            foreach (var ticket in queue)
            {
                Console.WriteLine(ticket);
            }
        }

        static void DisplayStack(Stack<string> stack)
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("No actions in undo history.");
                return;
            }

            foreach (var action in stack)
            {
                Console.WriteLine(action);
            }
        }
    }
}

