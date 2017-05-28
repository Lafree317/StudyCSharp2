using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2 {

    /**
     1：  1）定义Calculate接口，
     接口文件如下：
    interface Calculate
    {
            void getArea();  //计算圆面积。
            void getZC();    //计算圆周长
    }
        
         2） 定义circularity 类，实现接口Calculate. 且调试后输出结果。
    */

    interface ICalculate {
        void GetArea();  //计算圆面积。
        void GetZC();    //计算圆周长
    }
    class Circularity:ICalculate {

        private const float PI = 3.14159F;
        private float _FloR;

        public Circularity(float R) {
            _FloR = R;
        }

        // 实现了接口中的方法
        public void GetArea() {
            Console.WriteLine("圆的面积={0}", PI * _FloR * _FloR);
        }
        public void GetZC() {
            Console.WriteLine("计算圆周长:{0}",PI * _FloR*2);
        }
    }

    /*
     * 2：  设计一个类TClass, 继承下面的接口IMeasure, 实现其中的Length() 与 Area()方法，来计算特定长度等边三角形的边长和面积。
     interface IMeasure
     {
       int Length(int s);
       int Area(int s);
     }
     * 
     */

    interface IMeasure {
        int Length(int s);
        int Area(int s);
    }
    class TClass : IMeasure {
        // 边长
        public int Length(int s) {
            return s * 3;
        }
        // 面积
        public int Area(int s) {
            return (s * s)/2;
        }
    }

    // 3:   承上题，设计一个测试程序，创建TClass 的实例对象，调用其中的方法计算边长为10的三角形面积和周长。
    class TestClass {
        public void Start() {
            TClass c = new TClass();
            var length = c.Length(10);
            var area = c.Area(10);
            Console.WriteLine("边长为10的等边三角形,周长为:{0} 面积为{1}", length, area);
        }
    }
}
