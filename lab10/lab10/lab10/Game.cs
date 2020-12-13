using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Game
    {
        private string title;
        private int yearOfRealease;
        private string genre;

        public Game(string _title, int _yearOfRelease, string _genre)
        {
            title = _title;
            yearOfRealease = _yearOfRelease;
            genre = _genre;
        }

        public string Title
        {
            get => title;
            set
            {
                if (value == null)
                    title = "Игра";
                else
                    title = value;
            }
        }
        public int YearOfRelease
        {
            get => yearOfRealease;
            set
            {
                if (value < 1940)
                    yearOfRealease = 1940;
                else
                    yearOfRealease = value;
            }
        }
        public string Genre
        {
            get => genre;
            set
            {
                if (value == null)
                    genre = "Жанр";
                else
                    genre = value;
            }
        }
        public override string ToString() => $"Название - {Title}, год выхода - {YearOfRelease}, жанр - {Genre}";
    }
    
}
