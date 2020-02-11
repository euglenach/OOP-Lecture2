using System;

namespace Lecture2_2{
    public class Dog : Animal{
        
        public Dog(string name, int age) : base(name, age){}

        public override void Bark(){
            Console.WriteLine("わんわん");
        }
    }
}
