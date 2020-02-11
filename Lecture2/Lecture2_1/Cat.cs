using System;

namespace Lecture2{
    public class Cat : Animal{
        // フィールド
        public string Name;
        public int Age;

        // メソッド
        public void Bark(){
            Console.WriteLine("にゃーにゃー");
        }
        
        // コンストラクタ
        public Cat(string name, int age){
            Name = name;
            Age = age;
        }
    }
}
