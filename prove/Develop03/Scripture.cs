using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
public void HideRandomWords(int numberToHide)
{
    Random random = new Random();
    int count = 0;

    // Get a list of visible words
    var visibleWords = _words.Where(word => !word.IsHidden()).ToList();

    // Ensure the method doesn't try to hide more words than are visible
    numberToHide = Math.Min(numberToHide, visibleWords.Count);

    while (count < numberToHide)
    {
        
        int randomIndex = random.Next(visibleWords.Count);

       
        visibleWords[randomIndex].Hide();
        count++;

        
        visibleWords.RemoveAt(randomIndex);
    }
}


    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
