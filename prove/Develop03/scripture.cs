using System;
using System.Collections.Generic;
using System.Text;
public class Scripture{
    string theScripture;
    List<Word> theWord =new List<Word>();
    Random rand=new();
    public Scripture(string inputScripture){
        theScripture=inputScripture;
        theWord=scripturetoWords(theScripture);
    }
    private List<Word> scripturetoWords(string theScripture){
        List<Word> words=new List<Word>();
        StringBuilder word = new StringBuilder();

        foreach (char c in theScripture)
        {
            if (char.IsWhiteSpace(c))
            {
                if (word.Length > 0)
                {
                    words.Add(new Word(word.ToString()));
                    word.Clear();
                }
            }
            else
            {
                word.Append(c);
            }
        }
        // Add the last word if it exists
        if (word.Length > 0)
        {
            words.Add(new Word(word.ToString()));
        }
        return words;
    }
    public void HideRandomWord(){
        List<Word> visibleWords = theWord.Where(word => !word.IsHidden()).ToList();
        if (visibleWords.Count == 0) {
            return;
        }
        int newWord=rand.Next(visibleWords.Count);
        visibleWords[newWord].hide();
    }
    public string GetRenderedText()
    {
        StringBuilder renderedText = new StringBuilder();
        foreach (Word word in theWord)
        {
            renderedText.Append(word.GetRenderedText());
            renderedText.Append(" ");
        }
        return renderedText.ToString();
    }
}