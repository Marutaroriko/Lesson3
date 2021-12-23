struct Complex
{
    public int a; int b;
    public Complex (int re, int im)
    {
       this.a = re;    
       this.b = im;
    }

    public override string ToString()
    {
        string s;
        if (b<0) s=$"{a} - {-b}i";
        else s=$"{a} + {b}i";
        return s;
    }

    public static Complex operator + (Complex z1, Complex z2)
    {
        Complex result;
        result = new (z1.a+z2.a, z2.b+z1.b);
        return result;
    }

    public static Complex operator - (Complex z1, Complex z2)
    {
        Complex minus;
        minus = new (z1.a-z2.a, z1.b-z2.b);
        return minus;
    }
}