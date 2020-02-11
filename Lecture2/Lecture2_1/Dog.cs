using System;

namespace Lecture2{
    public class Dog : Animal{
        // フィールド
        public string Name;
        public int Age;

        // メソッド
        public void Bark(){
            Console.WriteLine("わんわん");
        }

        // コンストラクタ
        public Dog(string name, int age){
            Name = name;
            Age = age;
        }
    }
}
