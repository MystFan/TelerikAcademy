namespace DayOfWeekService
{
    using System;
    using System.Text;

    public class DayService : IDayService
    {
        public string GetDayOfWeek(DateTime date)
        {
            string day = date.DayOfWeek.ToString();
            switch (day)
            {
                case "Monday": day = "Понеделник"; break;
                case "Tuesday": day = "Вторник"; break;
                case "Wednesday": day = "Сряда"; break;
                case "Thursday": day = "Четвъртък"; break;
                case "Friday": day = "Петък"; break;
                case "Saturday": day = "Събота"; break;
                case "Sunday": day = "Неделя"; break;
            }

            var utf8 = Encoding.UTF8;
            byte[] utfBytes = utf8.GetBytes(day);
            day = utf8.GetString(utfBytes, 0, utfBytes.Length);

            return day;
        }
    }
}
