using System;
  
// namespace declaration
namespace csharp.people
{
    
    public class Person{
        public String name;
        public int Age;
        public bool HasPet;
        public void Greeting()
            {
                Console.WriteLine("My name is "+ name +" and my age is " +Age);

            }    
    }
}