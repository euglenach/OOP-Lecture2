using System;

namespace Lecture2{
    class Program{
        static void Main(string[] args){
            Dog dog = new Dog("ポチ",5);
            Cat cat = new Cat("タマ",2);
            
            dog.Bark();
            cat.Bark();
            
            
            // 下のコメントアウトを全部消せるのが目標 //
            
            // Animal animal1 = new Dog("ころね",12);
            // Animal animal2 = new Cat("ふぶき",12);

            // animal1.Bark();
            // animal2.Bark();


            // Animal[] animals = {new Dog("マロン", 1), new Cat("ショコラ",6)};
            //
            // foreach(var animal in animals){
            //     animal.Bark();
            // }
        }
    }
}
