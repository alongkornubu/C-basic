using System.Security.Cryptography;

namespace CsBasicBeginner;

public class Customer
{
    public string? Code {get; set;}
    public int Age {get; set;}
    public string? Name {get; set;}

    public Customer() {
        Console.WriteLine("start doing");
    }

    public Customer( string Name){
        this.Name = Name;
    }

    public void getValueName()
    {
        Console.WriteLine("name = " + Name);
    }

    public Customer(string Name, int Age , string Code){
        this.Name = Name;
        this.Age = Age;
        this.Code = Code;
    }

    public void getInfo() {
        Console.WriteLine("Name = {0} , Age= {1} , Code = {2}", Name , Age , Code);
    }

    public void jump() {
        for(int i = 0; i < 10; i++) {
            Console.WriteLine(i);
        }

        sayHi();
    }

    private void sayHi() {
        Console.WriteLine("Hi");
    }

    public void addNumber(int x , int y) {
        Console.WriteLine(x + y); 
    }

    public void sayHello(string name) {
        Console.WriteLine("Hello " + name);
    }

    public int sumNumber(int start, int end){
        int sum = 0;

        for(int i = start; i <= end; i++) {
            sum += i;
        }

        return sum;
    }
}
