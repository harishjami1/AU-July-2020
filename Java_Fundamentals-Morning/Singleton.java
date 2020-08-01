
class Singleton
{
// declaring instance variable
    private static Singleton inst = null;

    // variable of integer type
    public int k;

    // private constructor restricted to this class itself
    private Singleton()
    {
        k = 1;
    }

    // static method to create instance of Singleton class
    public static Singleton getInstance()
    {
        if (inst == null)
            inst = new Singleton();

        return inst;
    }
}

// Main Class
class Main
{
    public static void main(String args[])
    {
        // instantiating Singleton class with variable x
        Singleton x = Singleton.getInstance();

        // instantiating Singleton class with variable y
        Singleton y = Singleton.getInstance();

        // instantiating Singleton class with variable z
        Singleton z = Singleton.getInstance();




        System.out.println("String from x is " + x.k);
        System.out.println("String from y is " + y.k);
        System.out.println("String from z is " + z.k);
        System.out.println("\n");

        // changing variable of instance y
        y.k =3;

        System.out.println("String from x is " + x.k);
        System.out.println("String from y is " + y.k);
        System.out.println("String from z is " + z.k);
    }
}
