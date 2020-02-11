using System;

namespace Lecture2_2{
    public abstract class Animal{
        public string Name;
        public int Age;

        protected Animal(string name, int age){
            Name = name;
            Age = age;
        }

        public abstract void Bark();
    }
}
