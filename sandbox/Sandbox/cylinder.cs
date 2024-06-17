class Cylinder:Circle{
    public double height;
    public Cylinder(double r, double h):base(r){height=h;}

    public override double area()
    {
        return 2.0*base.area()*Math.PI*radius*height;
    }
}