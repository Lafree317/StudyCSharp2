using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 1： 设计一个基类，在其中创建方法MConvert，这个方法接受一个代表公里数的参数，将其转换为对等的英里数之后，然后创建一个继承此类的子类，增加可将输入的公斤数转换为磅的新方法 KConvert， 最后产生子类的实例对象， 测试这两个功能。
         提示信息：
                1千米(公里) = 0.62英里
                1千克（公斤） = 2.2磅 
      2： 调整上一题的内容，将其中的MConvert方法声明为virtual， 然后在子类中进行覆写，以其所接受的参数为正方形边长，转换为英里后计算其面积。
      3： 创建一个类，重写ToString() 方法， 当其被引用的时候，能够输出此类对象的说明文字，如下：
       “测试用的myObject 类对象”
 * 
 * 
 * 
 */
namespace test2 {
    class BaseClass{
        virtual public double MConvert(double km) {
            return km * 0.62;
        }
        
    }

    
    class Class:BaseClass {
        public double KConvert(double kg) {
            return kg * 2.2;
        }

        override public double MConvert(double km) {
            double mile = base.MConvert(km);
            return mile * mile;
        }
    }

    class OverrideToString {
        public override string ToString() {
            Console.WriteLine("测试用的{0}类对象", base.ToString());
            return base.ToString();
        }
    }
    
}
