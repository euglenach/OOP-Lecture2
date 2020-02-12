using System;

namespace Lecture2 {
    public class Dog {
        public string Name;
        public int Age;

        public Dog(string name,int age){
            Name = name;
            Age = age;
        }

        public void Bark(){
            Console.WriteLine("わんわん");
        }
    }
}
