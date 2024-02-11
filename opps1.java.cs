// Online Java Compiler
// Use this editor to write, compile and run your Java code online

class Fraction {
    private int numerator;
    private int denominator;
    public Fraction(int numerator,int denominator){
        this.numerator = numerator;
        this.denominator = denominator;
        simplify();
    }
    
    private void simplify(){
        int gcd =1;
        int smaller = Math.min(numerator,denominator);
        for (int i =2;i<=smaller;i++){
            if(numerator%i == 0 && denominator%i ==0)
            {
                gcd = i;
            }
        }
        numerator = numerator/gcd;
        denominator = denominator/gcd;
    }
    
    public void print(){
        System.out.println(numerator+"/"+denominator);
    }
    public void increment(){
        numerator = numerator+denominator;
        
    }
    public void addFraction(Fraction f2){
        this.numerator = this.numerator*f2.denominator + this.denominator*f2.numerator;
        this.denominator = this.denominator*f2.denominator;
        simplify();
    }
    
    public static Fraction addFraction(Fraction f1, Fraction f2)
    {
            int newnume = f1.numerator*f2.denominator + f1.denominator*f2.numerator;
        int newdeno = f1.denominator*f2.denominator;
        Fraction f3 = new Fraction(newnume,newdeno);
        return f3;
    }
}

// Static variables are accessed by using the class variables.

class HelloWorld {
    public static void main(String[] args) {
        Fraction f1 = new Fraction(4,6);
        
        f1.print();
        //f1.increment();
        f1.print();
        Fraction f2 = new Fraction(4,8);
        f1.addFraction(f2);
        f1.print();
        Fraction f3 = Fraction.addFraction(f1,f2);
        f3.print();
        
    }
}
