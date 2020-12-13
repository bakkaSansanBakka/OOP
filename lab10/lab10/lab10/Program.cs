using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static ObservableCollection<Game> observable;
        static void ObsCollectionEventHandler(string Message) => Console.WriteLine(Message);

        static void Main(string[] args)
        {
            Game game1 = new Game("DOOM", 1993, "Shooter");
            Game game2 = new Game("The Sims", 2000, "Life simulator");
            Game game3 = new Game("Fire Emblem", 2003, "Strategy");

            GameCollection gameArray = new GameCollection();

            gameArray.Add(game1);
            gameArray.Add(game2);
            gameArray.Add(game3);
            gameArray.Display();
            Console.WriteLine();

            gameArray.Remove(game3);
            gameArray.Display();
            Console.WriteLine();

            Console.WriteLine($"Совпадение найдено: {gameArray.Find("DOOM")}\n");

            BlockingCollectionType<int> intCollection = new BlockingCollectionType<int>();
            intCollection.Add(2);
            intCollection.Add(15);
            intCollection.Add(239);
            intCollection.Add(4);
            intCollection.Add(14);
            intCollection.Add(65);
            intCollection.Display();

            int n = 3;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Изъят элемент: {intCollection.Take()}");
            }
            intCollection.Display();

            QueueType<char> queueSimple = new QueueType<char>();
            queueSimple.Enqueue('s');
            queueSimple.Enqueue('d');
            queueSimple.Enqueue('e');
            queueSimple.Display();

            var obsCol = new ObservableCollection<Game>();

            Console.WriteLine("\nОбозреваемая коллекция:");
            obsCol.CollectionChanged += ObsCollectionEventHandler;
            obsCol.Add(game1);
            obsCol.Add(game2);
            obsCol.Remove(game1);
            Console.Read();
        }
    }
}
