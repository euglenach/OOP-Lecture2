using System;

namespace Lecture2 {
    public class Cat {
        public string Name;
        public int Age;

        public Cat(string name,int age){
            Name = name;
            Age = age;
        }
        
        public void Bark(){
            Console.WriteLine("わんわん");
        }
    }
}
