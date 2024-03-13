using System;
using System.Collections.Generic;


class Scripture
{
    private List<VerseWord> words;
    private VerseReference reference;

    public Scripture(string fullReference, string text)
    {
        words = new List<VerseWord>();
        reference = new VerseReference(fullReference);

        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            words.Add(new VerseWord(word));
        }
    }

    public void Display()
    {
        Console.WriteLine(reference.FullReference);
        foreach (VerseWord word in words)
        {
            Console.Write(word.GetHiddenText() + " ");
        }
        Console.WriteLine("\n");
        Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
    }

    public bool HideRandomWord()
    {
        bool allWordsHidden = true;
        foreach (VerseWord word in words)
        {
            if (!word.Hidden)
            {
                allWordsHidden = false;
                break;
            }
        }

        if (allWordsHidden)
            return false;

        Random rand = new Random();
        int index = rand.Next(words.Count);
        while (words[index].Hidden)
        {
            index = rand.Next(words.Count);
        }
        words[index].Hidden = true;

        return true;
    }
}