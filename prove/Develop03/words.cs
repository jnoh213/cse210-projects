using System.Net;

public class Word{
    string theWord;
    string hiddenWord;
    bool isHidden=false;
    public Word(string newWord){
        theWord=newWord;
        hiddenWord=replaceWithUnderscore(theWord);
    }
    public void hide(){
        isHidden=true;
    }
    public void show(){
        isHidden=false;
    }
    public bool IsHidden(){
        return isHidden;
    }
    public string GetRenderedText(){
        if (isHidden==true){
            return hiddenWord;
        }
        else{
            return theWord;
        }
    }
    static string replaceWithUnderscore(string theWord){
        char[] result=new char[theWord.Length];
        for (int i=0;i<theWord.Length;i++){
            result[i]='_';
        }
        return new string(result);
    }
}