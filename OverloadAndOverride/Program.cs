using System;

class Alpha
{
    public int alpha;
    public void set()
    {
        alpha = 10;

        Console.WriteLine("Alpha(bez argumentov): {0}", alpha);
    }
    public virtual void set(int n)
    {
        alpha = n;
        Console.WriteLine("Alpha(odin argument): {0}", alpha);
    }
}
class Bravo: Alpha
{
    public int bravo;
    public override void set(int n)
    {
        
            alpha = n;
        bravo = alpha;
            Console.WriteLine("Bravo(odin argumentov): {0}and{1}", alpha,bravo);
        }    
    public void set(int m,int n)
    {
        alpha = m;
        bravo = n;
        Console.WriteLine("Bravo(dva argumenta): {0}and{1}", alpha,bravo);
    }
}
class OverloadAndOverrideDemo
{
    static void Main()
    {
        Alpha A= new Alpha();
        A.set();
        A.set(20);
        Console.WriteLine();
        Bravo B = new Bravo();
        B.set();
        B.set(30);
        B.set(40, 50);
    }
}
