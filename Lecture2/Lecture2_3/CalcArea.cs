using System;

namespace Lecture2_3{
    /// <summary>
    /// オブジェクト指向的ではない設計のクラス
    /// </summary>
    public static class CalcArea{
        public static double TriangleArea(double bottom, double height){
            return bottom * height * .5;
        }
        
        public static double CircleArea(double radius){
            return Math.PI * radius * radius;
        }
        
        public static double SquareArea(double bottom, double height){
            return bottom * height;
        }
    }
}
