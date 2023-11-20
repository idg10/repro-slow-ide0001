namespace MakeIde0001GoSlow
{
    /// <summary>
    /// Causes IDE0001 to go very slowly.
    /// </summary>
    /// <remarks>
    /// <para>
    /// After any edit to this file (even a single key stroke) we see the Background Tasks animation
    /// on Visual Studio's task bar at the bottom left of the screen run for about a minute.
    /// </para>
    /// <para>
    /// Another issue (although this seems sporadic) is that sometimes, copying lines of code to the
    /// clipboard is very slow. Click on one of the more complex entries in the initializer for the
    /// <see cref="Sloooow"/> property (e.g., the 7th in the list) property, and then hit Ctrl+C to
    /// copy the entire line to the clipboard. This causes the "Please wait for an editor command
    /// to finish" progress window to open, and it takes around 10 seconds to go away.
    /// </para>
    /// </remarks>
    public static class Repro
    {
        public static MemberTable Sloooow { get; } = new MemberTable
        {
                (long ticks) => new global::System.DateTime(ticks),
                (long ticks, DateTimeKind kind) => new global::System.DateTime(ticks, kind),
                (int year, int month, int day) => new global::System.DateTime(year, month, day),
                (int year, int month, int day, int hour, int minute, int second) => new global::System.DateTime(year, month, day, hour, minute, second),
                (int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) => new global::System.DateTime(year, month, day, hour, minute, second, kind),
                (int year, int month, int day, int hour, int minute, int second, int millisecond) => new global::System.DateTime(year, month, day, hour, minute, second, millisecond),
                (int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind) => new global::System.DateTime(year, month, day, hour, minute, second, millisecond, kind),

                () => global::System.DateTime.MaxValue,
                () => global::System.DateTime.MinValue,

                (global::System.DateTime dt) => dt.Date,
                (global::System.DateTime dt) => dt.Day,
                (global::System.DateTime dt) => dt.DayOfWeek,
                (global::System.DateTime dt) => dt.DayOfYear,
                (global::System.DateTime dt) => dt.Hour,
                (global::System.DateTime dt) => dt.Kind,
                (global::System.DateTime dt) => dt.Millisecond,
                (global::System.DateTime dt) => dt.Minute,
                (global::System.DateTime dt) => dt.Month,
                (global::System.DateTime dt) => dt.Second,
                (global::System.DateTime dt) => dt.Ticks,
                (global::System.DateTime dt) => dt.TimeOfDay,
                (global::System.DateTime dt) => dt.Year,

                (global::System.DateTime t1, global::System.DateTime t2) => global::System.DateTime.Compare(t1, t2),
                (global::System.DateTime t1, global::System.DateTime t2) => global::System.DateTime.Equals(t1, t2),

                (double d) => global::System.DateTime.FromOADate(d),
                (long fileTime) => global::System.DateTime.FromFileTimeUtc(fileTime),
                (int year) => global::System.DateTime.IsLeapYear(year),
                (int year, int month) => global::System.DateTime.DaysInMonth(year, month),
                (global::System.DateTime value, global::System.DateTimeKind kind) => global::System.DateTime.SpecifyKind(value, kind),

                (global::System.DateTime dt) => dt.ToOADate(),

                (global::System.DateTime dt, global::System.TimeSpan value) => dt.Add(value),
                (global::System.DateTime dt, double value) => dt.AddDays(value),
                (global::System.DateTime dt, double value) => dt.AddHours(value),
                (global::System.DateTime dt, double value) => dt.AddMilliseconds(value),
                (global::System.DateTime dt, double value) => dt.AddMinutes(value),
                (global::System.DateTime dt, int months) => dt.AddMonths(months),
                (global::System.DateTime dt, double value) => dt.AddSeconds(value),
                (global::System.DateTime dt, long value) => dt.AddTicks(value),
                (global::System.DateTime dt, int value) => dt.AddYears(value),
                (global::System.DateTime dt, global::System.DateTime value) => dt.Subtract(value),
                (global::System.DateTime dt, global::System.TimeSpan value) => dt.Subtract(value),

                (global::System.DateTime dt, global::System.DateTime value) => dt.CompareTo(value),
                (global::System.DateTime dt, global::System.DateTime value) => dt.Equals(value),

                (global::System.DateTime dt, global::System.TimeSpan ts) => dt + ts,
                (global::System.DateTime dt, global::System.TimeSpan ts) => dt - ts,
                (global::System.DateTime dt1, global::System.DateTime dt2) => dt1 - dt2,
                (global::System.DateTime dt1, global::System.DateTime dt2) => dt1 == dt2,
                (global::System.DateTime dt1, global::System.DateTime dt2) => dt1 != dt2,
                (global::System.DateTime dt1, global::System.DateTime dt2) => dt1 < dt2,
                (global::System.DateTime dt1, global::System.DateTime dt2) => dt1 <= dt2,
                (global::System.DateTime dt1, global::System.DateTime dt2) => dt1 > dt2,
                (global::System.DateTime dt1, global::System.DateTime dt2) => dt1 >= dt2,
        };
    }
}
