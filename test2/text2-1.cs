using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test2 {
    
    class Program {
        /*
            1：利用多态性实现多功能计算器：
            1）定义方法名为computeMethod 的方法，实现加法器。
            2）再定义方法名为computeMethod 的方法，实现具备加减乘除综合计算功能。
            3）在main 方法中调用以上方法，且测试。
        */
        static void Main(string[] args) {
            Program obj = new Program();
            var result1 = obj.ComputeMethod(1, 2); // 3
            var result2 = obj.ComputeMethod(1, 2, "-"); // -1
            Console.WriteLine(result1 + "   " + result2);
        }

        // 加
        public float ComputeMethod(float num1, float num2) {
            return num1 + num2;
        }

        // 加减乘除
        public float ComputeMethod(float num1, float num2,string option) {
            float result = 0;
            switch (option) {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("输入有误");
                    break;
            }
            return result;
        }
    }

    /*
        2：利用多态性实现如下功能。
        1）定义一个Father 类，利用构造方法的重载概念定义三个构造方法。
        2）定义Child 类继承Father类，在Child的构造方法中分别调用父类不同的构造方法。
     */
    public class Father {
        private string _property1;
        private string _property2;
        

        public Father() {
            _property1 = "没赋值";
            _property2 = "没赋值";
        }

        public Father(string str) {
            _property1 = str;
            
        }

        public Father(string str1,string str2) {
            _property1 = str1;
            _property2 = str2;
        }
        public void PrintProperty() {
            Console.WriteLine("第一个参数:{0} 第二个参数:{1}", _property1, _property2);
        }
    }

    public class Child : Father {
        public Child():base() {
            Father c1 = new Father("1", "2");
            Father c2 = new Father("1");
            Father c3 = new Father();
        }
        public Child(string str) : base(str) {

        }
        public Child(string str1,string str2) : base(str1, str2) {

        }
        public void Start() {

            Child c = new Child("1");
            c.PrintProperty();
        }
    }
}
