using System.Collections.Concurrent;

public class Refrence{
    private string book;
    string Chapter;
    string theVerse;
    string startVerse;
    string endVerse;
    bool multiVerse;
    public Refrence(string theBook,string theChapter,string theStart, string theEnd){
        book=theBook;
        Chapter=theChapter;
        startVerse=theStart;
        endVerse=theEnd;
        multiVerse=true;
    }
    public Refrence(string theBook,string theChapter,string verse){
        book=theBook;
        Chapter=theChapter;
        theVerse=verse;
        multiVerse=false;
    }
    
}