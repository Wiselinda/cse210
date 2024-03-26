using System;
using System.Collections.Generic;
using System.IO;


class Goal
{
    public string Name { get; set; }
    public int Value { get; set; }
    public bool Completed { get; set; }

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        Completed = false;
    }

    public virtual void Complete()
    {
        Completed = true;
    }

    public virtual string GetStringRepresentation()
    {
        return $"{Name}:{Value}:{Completed}";
    }
}
