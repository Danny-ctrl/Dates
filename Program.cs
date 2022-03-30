using System;
using System.Globalization;

namespace Datas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      // 
      var data = DateTime.Now;
      var formatada = String.Format("{0:yyyy/MM/dd hh:mm:ss ff z}", data);
      var forma = String.Format("{0:r}", data);
      System.Console.WriteLine(formatada);
      System.Console.WriteLine(forma);

      System.Console.WriteLine(data);
      System.Console.WriteLine(data.AddDays(-12));
      System.Console.WriteLine(data.AddMonths(1));
      System.Console.WriteLine(data.AddHours(1));

      if (data.Date == DateTime.Now.Date)
      {
        System.Console.WriteLine("É igual");
      }
      System.Console.WriteLine(data);

      var pt = new CultureInfo("pt-PT");
      var en = new CultureInfo("en-US");
      var atual = CultureInfo.CurrentCulture;
      System.Console.WriteLine(DateTime.Now.ToString("D", atual));


      var utcDate = DateTime.UtcNow;
      System.Console.WriteLine(DateTime.Now);
      System.Console.WriteLine(utcDate);
      System.Console.WriteLine(utcDate.ToLocalTime());

      var timezoneAustralia =
      TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
      Console.WriteLine(timezoneAustralia);
      var horaAustralia =
      TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
      System.Console.WriteLine(horaAustralia);



      var timeSpan = new TimeSpan();
      System.Console.WriteLine(timeSpan);
      var timeSpanNanosegundos = new TimeSpan(1);
      System.Console.WriteLine(timeSpanNanosegundos);
    }
  }
}
