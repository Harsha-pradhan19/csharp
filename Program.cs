using System;
  
// namespace declaration
namespace csharp {
      
    // Class declaration
    class Person{
        public String name;
        public int Age;
        public bool HasPet;
        public void Greeting()
            {
                Console.WriteLine("My name is "+ name +" and my age is " +Age);

            
    }}
    class Program {
          
        // Main Method
        static void Main(string[] args) {
         
         Person p=new Person();
         p.name="Harsha";
         p.Age=23;
         p.HasPet=false;
         p.Greeting();
        }
    }
}