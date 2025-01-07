using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // var data = new DateTime(2025, 01, 02, 10, 26, 00); 
            // var data = DateTime.Now; 

            // Console.WriteLine(data);
            // Console.WriteLine(data.Year);
            // Console.WriteLine(data.Month);
            // Console.WriteLine(data.Day);
            // Console.WriteLine(data.Hour);
            // Console.WriteLine(data.Minute);
            // Console.WriteLine(data.Second);
            // Console.WriteLine(data.DayOfWeek);
            // Console.WriteLine((int)data.DayOfWeek);
            // Console.WriteLine(data.DayOfYear);


            // PADROES DE FORMATAÇAO ----------------------------------------------------------

            // var data = DateTime.Now;

            // var formatada = String.Format("{0:dd-MM-yyyy hh:mm:ss}", data);
            //var formatada = String.Format("{0:t}", data); //  a hora resumido
            //var formatada = String.Format("{0:T}", data); //  a hora por extenso
            //var formatada = String.Format("{0:d}", data); //  a data resumido
            //var formatada = String.Format("{0:D}", data); //  a data por extenso
            //var formatada = String.Format("{0:f}", data); //  a data e hora
            //var formatada = String.Format("{0:g}", data); //  a data e hora por extenso
            //var formatada = String.Format("{0:r}", data); 
            //var formatada = String.Format("{0:s}", data); 
            //var formatada = String.Format("{0:u}", data); 
            // Console.WriteLine(formatada);


            // ADICIONANDO VALORES ----------------------------

            // var data = DateTime.Now;

            // Console.WriteLine(data.AddDays(12));

            // Console.WriteLine(data.AddMonths(1));

            // Console.WriteLine(data.AddYears(1));


            // COMPARANDO DATAS ------------------------------------

            // var data = DateTime.Now;

            // if (data.Date == DateTime.Now.Date) 
            // {
            //     Console.WriteLine("É igual!");
            // }

            // Console.WriteLine(data);


            // CULTUREINFO -------------------------------------------

            // var pt = new CultureInfo("pt-PT");
            // var br = new CultureInfo("pt-BR");
            // var en = new CultureInfo("en-US");
            // var de = new CultureInfo("en-DE");
            // var atual = CultureInfo.CurrentCulture; 

            // Console.WriteLine(DateTime.Now.ToString("D", atual));
            // // Console.WriteLine(string.Format("{0:D}", DateTime.Now));


            // TIMEZONE --------------------------------------------------

            // Console.Clear();

            // var utcDate = DateTime.UtcNow; 

            // Console.WriteLine(DateTime.Now);
            // Console.WriteLine(utcDate);
            // Console.WriteLine(utcDate.ToLocalTime());

            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            // Console.WriteLine(timezoneAustralia);

            // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            // Console.WriteLine(horaAustralia);

            // var timezones = TimeZoneInfo.GetSystemTimeZones();
            // foreach (var timezone in timezones)
            // {
            //     Console.WriteLine(timezone.Id);
            //     Console.WriteLine(timezone);
            //     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia));
            //     Console.WriteLine("----------------------");

            // }

            // TIMESPAN ----------------------------------------------------

            Console.Clear();

            // var timeSpanNanosegundos = new TimeSpan(1);
            // Console.WriteLine(timeSpanNanosegundos);

            // var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            // Console.WriteLine(timeSpanHoraMinutoSegundo);

            // var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            // var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

            // Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

            Console.WriteLine(DateTime.DaysInMonth(2025, 2)); // dias no mes
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());



            static bool IsWeekend(DayOfWeek today)

            {
                return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
            }
        }
    }
}
