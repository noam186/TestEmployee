using System;

/// <summary>
/// Summary description for Class1
/// </summary>

    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int GetDay()
        {
            return this.day;
        }

        public void SetDay(int day)
        {
            this.day = day;
        }

        public int GetMonth()
        {
            return this.month;
        }

        public void SetMonth(int month)
        {
            this.month = month;
        }

        public int GetYear()
        {
            return this.year;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }
    }
