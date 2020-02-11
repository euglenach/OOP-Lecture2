using System;

namespace Lecture2_2{
    public class Cat : Animal{
        
        public Cat(string name, int age) : base(name, age){}

        public override void Bark(){
            Console.WriteLine("にゃーにゃー");
        }
    }
}
