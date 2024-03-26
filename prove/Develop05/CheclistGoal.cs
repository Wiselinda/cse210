using System;
using System.Collections.Generic;
using System.IO;


class ChecklistGoal : Goal
{
    public int TotalTimes { get; set; }
    public int TimesCompleted { get; set; }

    public ChecklistGoal(string name, int value, int totalTimes) : base(name, value)
    {
        TotalTimes = totalTimes;
        TimesCompleted = 0;
    }

    public override void Complete()
    {
        TimesCompleted++;
        if (TimesCompleted == TotalTimes)
        {
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}:{TimesCompleted}/{TotalTimes}";
    }
}