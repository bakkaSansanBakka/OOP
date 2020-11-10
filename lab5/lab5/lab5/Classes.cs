using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Organization
    {
        private protected Date date;
        private protected string nameOfOrganization;
        public string NameOfOrganization { get => nameOfOrganization; set => nameOfOrganization = value; }
        public Organization()
        {
            nameOfOrganization = "MMM";
            date = new Date(7, 11, 2020);
        }
        public Organization(string orgName, int dateDay, int dateMonth, int dateYear)
        {
            nameOfOrganization = orgName;
            date = new Date(dateDay, dateMonth, dateYear);
        }

        // Переопределенные методы Object

        public override string ToString() => $"Организация – {nameOfOrganization}, " +
            $"дата создания – {date.Day}.{date.Month}.{date.Year}";
        public override int GetHashCode() => HashCode.Combine(nameOfOrganization, date.Day, date.Month, date.Year);
        public override bool Equals(object obj)
        {
            if (obj is Organization objectType)
            {
                if (this.date.Day == objectType.date.Day
                        && this.date.Month == objectType.date.Month
                            && this.date.Year == objectType.date.Year
                                && this.nameOfOrganization == objectType.nameOfOrganization)
                {
                    return true;
                }
            }
            return false;
        }
    }
    public class Date
    {
        int year;
        int month;
        int day;
        public int Year { get => year; set => year = value; }
        public int Month 
        { 
            get => month;
            set 
            {
                if (value < 1)
                    month = 1;
                else if (value > 12)
                    month = 12;
                else
                    month = value;
            }
        }
        public int Day
        {
            get => day;
            set
            {
                if (value < 1)
                    day = 1;
                else if (value > 31)
                    day = 31;
                else
                    day = value;
            }
        }
        public Date(int dateDay, int dateMonth, int dateYear)
        {
            Day = dateDay;
            Month = dateMonth;
            Year = dateYear;
        }
        public void DateInformation() => Console.WriteLine($"Дата создания: {day}.{month}.{year}");
    }
    public class Document : Organization
    {
        private protected bool stamp;
        public bool IsStamped { get => stamp; set => stamp = value; }
        public Document(string organizationName, int dateDay, int dateMonth, int dateYear, bool isStamped) 
            : base(organizationName, dateDay, dateMonth, dateYear)
        {
            stamp = isStamped;
        }
        public override string ToString()
        {
            return base.ToString() + $", есть ли печать – " + (stamp ? "есть" : "нет");
        }
    }
    public class Receipt : Document //квитанция
    {
        private protected string docType;
        public string DocType { get => docType; set => docType = value; }
        public Receipt(string organizationName, int dateDay, int dateMonth, int dateYear, bool isStamped, string documentType)
            : base(organizationName, dateDay, dateMonth, dateYear, isStamped)
        {
            docType = documentType;
        }
        
    }
    public class Invoice : Document //накладная
    {
        private protected string docType;
        public string DocType { get => docType; set => docType = value; }
        public Invoice(string organizationName, int dateDay, int dateMonth, int dateYear, bool isStamped, string documentType)
            : base(organizationName, dateDay, dateMonth, dateYear, isStamped)
        {
            docType = documentType;
        }
    }
    public class Check : Document   //чек
    {
        private protected string docType;
        public string DocType { get => docType; set => docType = value; }
        public Check(string organizationName, int dateDay, int dateMonth, int dateYear, bool isStamped, string documentType)
            : base(organizationName, dateDay, dateMonth, dateYear, isStamped)
        {
            docType = documentType;
        }
    }
}
