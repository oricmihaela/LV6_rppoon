using LV6_rppoon.Lanac_Odgovornosti;
using LV6_rppoon.LVIterator;
using LV6_rppoon.Memento;
using System;

namespace LV6_rppoon
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. zadatak testiranje
            Console.WriteLine("Testing task no. 1:");
            Notebook myNotebook = new Notebook();
            Note uniNote = new Note("Uni", "Exam on friday!");
            Note homeNote = new Note("Home", "Change the lightbulb in the kitchen.");
            Note orchestraNote = new Note("Orchestra", "Rehearsal at 8.");
            myNotebook.AddNote(uniNote);
            myNotebook.AddNote(homeNote);
            myNotebook.AddNote(orchestraNote);
            IAbstractIterator iterator = myNotebook.GetIterator();
            for (iterator.First(); !(iterator.IsDone); iterator.Next())
            {
                iterator.Current.Show();
            }

            //2. zadatak testiranje
            Console.WriteLine("Testing task no. 2:");
            Box myBox = new Box();
            Product fruit = new Product("bananas, 2kg", 20);
            Product juice = new Product("apple juice, 1l", 5);
            myBox.AddProduct(fruit);
            myBox.AddProduct(juice);
            IBoxIterator boxIterator = myBox.GetIterator();
            for(boxIterator.First(); !(boxIterator.IsDone); boxIterator.Next())
            {
                boxIterator.Current.Show();
            }


            //4. zadatak testiranje
            Console.WriteLine("Testing task no. 4:");
            BankAccount mihaelasAccount = new BankAccount("Mihaela", "Sl. Kobas", 4000);
            BankCareTaker bankCareTaker = new BankCareTaker();
            BankMemento bankMemento = new BankMemento(mihaelasAccount);
            bankCareTaker.PreviousState = bankMemento;
            mihaelasAccount.UpdateBalance(-2000);
            Console.WriteLine(mihaelasAccount.Balance);
            bankCareTaker.PreviousState = bankMemento;
            Console.WriteLine(bankCareTaker.PreviousState.Balance);    //prvi iznos bio je 4000, zatim 2000, ispis bi trebao biti 2000 pa 4000

            //5. zadatak testiranje
            Console.WriteLine("Testing task no. 5:");
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger =
            new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");
            logger.Log("info", MessageType.INFO);
            logger.Log("Error", MessageType.ERROR);
            logger.Log("Warning", MessageType.WARNING);

        }
    }

}
