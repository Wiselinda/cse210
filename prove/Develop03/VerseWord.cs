using System;
using System.Collections.Generic;

class VerseWord
{
    public string Text { get; set; }
    public bool Hidden { get; set; }

    public VerseWord(string text)
    {
        Text = text;
        Hidden = false;
    }

    public string GetHiddenText()
    {
        if (Hidden)
            return new string('_', Text.Length);
        else
            return Text;
    }
}
