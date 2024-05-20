public class Fraction{
    private int _top;
    private int _bottom;
    public Fraction(){
        _top=1;
        _bottom=1;
    }
    public void onlyTop(int top){
        _top=top;
        _bottom=1;
    }
    public void bothNumbers(int top, int bottom){
        _top= top;
        _bottom= bottom;
    }
    public void SetTop(int top){ _top=top; }
    public int GetTop(){ return _top; }
    public void SetBottom(int bottom){ _bottom=bottom; }
    public int GetBottom(){ return _bottom; }
    public string GetFractionToString(){
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue(){
        return Convert.ToDouble(_top)/Convert.ToDouble(_bottom);
    }

}