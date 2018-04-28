using System;

using Humanizer;

public struct DateRange
{
    public DateTimeOffset From { get; set; }

    public DateTimeOffset To { get; set; }

    public override string ToString()
    {
        if (From.Month == To.Month)
        {
            return $"{From:MMMM d}-{To.Day.Ordinalize()}, {To:yyyy}";
        }

        return $"{From:MMMM} {From.Day.Ordinalize()}-{To:MMMM} {To.Day.Ordinalize()}, {To:yyyy}, {To:yyyy}";
    }
}