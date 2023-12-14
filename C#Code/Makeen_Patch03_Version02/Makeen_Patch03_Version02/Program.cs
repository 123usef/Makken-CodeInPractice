using Makeen_Patch03_Version02.Nature;

namespace Makeen_Patch03_Version02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eagle eg = new Eagle();
            eg.move();
            Dog dog = new Dog();
            //dog.
            Animal ani = new Animal();
            //ani.fly();
            eg.fly(); // child 
            eg.move();// parent 
        }
    }
}