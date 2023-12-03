

namespace MakeenPatch03_Day13
{
     interface IMove
    {
        void Move();
        void Eat();
        void Sleep();
    }
     interface IWork
    {
        void Eat();
        void Work();
    }
    abstract class Creature
    {
        public string Type; 
    }
   abstract  class People : Creature, IMove , IWork
    {
        
        Array
        #region Members
        public int Id;
        public string Name;
        public int Age;
        public int SSN;
        public string Address;

        #endregion
        #region Construcotr

        public People()
        {

        }

        // Default Contructor empty
        // Creating object from people should take below Values 
        public People(int Id, string Name, int Age, int SSN, string Address)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.SSN = SSN;
            this.Address = Address;
        }

	#endregion     
        public override string ToString()
        {
            return $"hello mr {this.Name}";
        }

        public virtual void CalculateSalary()
        {
            Console.WriteLine("your Salary is Claculated According to : ");
        }

        public void Move()
        {
            Console.WriteLine(" i am MOVING ");
        }

         void IMove.Eat()
        {
            Console.WriteLine("I AM Eating ");
        }
        void IWork.Eat()
        {
            Console.WriteLine("I AM Eating ");
        }

        public void Sleep()
        {
            Console.WriteLine("i am Sleeping ");
        }
        public void Work()
        {

        }
    }
}
