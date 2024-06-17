class Circle : RoundShape
{
    protected double radius;
    public Circle(double r){
        radius=r;
    }
    public override double area(){
        return(Math.PI*radius*radius);
    }
}