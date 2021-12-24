using System.Globalization;

DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

int workingDays = 0;
bool holiday = false;

List<DateTime> holidays = new List<DateTime>()
            {
                DateTime.ParseExact("01-01-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            };

for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
{
    if (i.DayOfWeek.Equals("Saturday") || i.DayOfWeek.Equals("Sunday"))
    {
        holiday = true;
    }
    if (!holidays.Contains(i))
    {
        workingDays++;
    }
}
Console.WriteLine(workingDays);
