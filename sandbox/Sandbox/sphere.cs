class Sphere:Circle{
    public Sphere(double r):base(r){}

    public override double area()
    {
        return 4.0*base.area();
    }
}