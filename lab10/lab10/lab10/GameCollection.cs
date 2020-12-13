using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class GameCollection : IEnumerable<Game>, IEnumerator<Game>
    {
        List<Game> gameList;

        public GameCollection()
        {
            gameList = new List<Game>();
        }
        int position = -1;

        // реализация IEnumerable и IEnumerator
        public IEnumerator<Game> GetEnumerator()
        {
            return this;
        }
        public bool MoveNext()
        {
            position++;
            return (position < gameList.Count);
        }

        void IDisposable.Dispose() { }
        public void Reset()
        {
            position = 0;
        }

        bool IEnumerator.MoveNext() => MoveNext();
        void IEnumerator.Reset() => Reset();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        Game IEnumerator<Game>.Current => gameList[position];
        object IEnumerator.Current => gameList[position];

        public void Add(Game item)
        {
            gameList.Add(item);
        }
        public void Remove(Game item)
        {
            gameList.Remove(item);
        }
        public Game Find(string item) => gameList.Find(el => el.Title == item);

        public void Display()
        {
            foreach (Game game in gameList)
            {
                Console.WriteLine(game.ToString());
            }
                
        }
    }
}
