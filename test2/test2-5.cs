using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

/*
 * 
 * 
 *  1：  设计一个程序，创建ArrayList对象，存储利用Random 类产生的10个随机数值，
     并在排序之后输出到控制台。
    2：  使用ArrayList 类代替数组，做门票系统。
    1>、当age<14,“儿童票”。
       当14<=age<65,“成人票”。
       当65<=age,“老年票”。
    2>、打印出姓名和对应的票。

    3:   有一个已经排好序的数组{12,20,45,56,72,89,91,121,256}。
     现输入一个数，要求按原来的规律将它插入数组中，且输出，
     使用ArrayList 类。
 * 
 * 
 */
namespace test2 {
    public class ArrayClass {
        public void Start() {
            TicketClass();
            Console.ReadLine();
        }

        // 1：  设计一个程序，创建ArrayList对象，存储利用Random 类产生的10个随机数值，
        // 并在排序之后输出到控制台。
        private void RandomSortArr() {
            ArrayList rArr = new ArrayList(10);
            Random ran = new Random();

            for (int i = 0; i < 10; i++) {

                int randomNumber = ran.Next(0, 100);
                rArr.Add(randomNumber);
            }
            Console.WriteLine("随机生成的数组:");
            PrintArr(rArr);

            rArr.Sort();
            Console.WriteLine("排序后的数组:");
            PrintArr(rArr);
        }
        private void PrintArr(ArrayList arr) {
            string result = "";
            foreach (int i in arr) {
                result += (i.ToString() + " ");
            }
            Console.WriteLine(result);
        }

        /*
         * 
         * 
         *   2：  使用ArrayList 类代替数组，做门票系统。
             1>、当age<14,“儿童票”。
                当14<=age<65,“成人票”。
                当65<=age,“老年票”。
             2>、打印出姓名和对应的票。
         * 
         */
        private void TicketClass(){
            ArrayList list = new ArrayList();
            while (true) {
                Console.WriteLine("姓名:");
                string name =  Console.ReadLine();
                Console.WriteLine("年龄:");
                string ageStr = Console.ReadLine();
                if (IsExists(ageStr)) {
                    Console.WriteLine("输入的不是数字 请重新输入:");
                    continue;
                }
                int age = Convert.ToInt32(ageStr);
                Dictionary<string,int > dic = new Dictionary<string, int>{ { name, age } };
                list.Add(dic);

                PrintTicketList(list);
            }
        }

        
        private void PrintTicketList(ArrayList list) {
            foreach (Dictionary<string,int> dic in list) {
                var a = dic.First();
                int age = a.Value;
                string ticket = "";
                if (age >= 65) {
                    ticket = "老年票";
                } else if (age >= 14) {
                    ticket = "成人票";
                } else {
                    ticket = "儿童票";
                }
                Console.WriteLine("姓名:{0},年龄:{1},票价:{2}", a.Key, a.Value, ticket);
            }
        }

        /*
         * 
         * 
         *  3:   有一个已经排好序的数组{12,20,45,56,72,89,91,121,256}。
            现输入一个数，要求按原来的规律将它插入数组中，且输出，
            使用ArrayList 类。
         * 
         */
        public void ArrayListInsert() {
            int[] nums = new int[] { 12, 20, 45, 56, 72, 89, 91, 121, 256 };
            ArrayList arrNums = new ArrayList(nums);
            Console.WriteLine("当前数组:");
            PrintArr(arrNums);
            while (true) {
                string readStr = Console.ReadLine();
                if (IsExists(readStr)) {
                    Console.WriteLine("错误的输入请重新输入数字:");
                    continue;
                }
                int num = Convert.ToInt32(readStr);
                arrNums.Add(num);
                arrNums.Sort();
                Console.WriteLine("插入排序后的数组:");
                PrintArr(arrNums);
            }
         }

        // 判断是否包含非数字内容
        public static bool IsExists(string str) {
            if (str == "") {
                return true;
            }
            var a = Regex.IsMatch(str, "^[\u4e00-\u9fa5_a-zA-Z]+$");
            return a;
        }

    }

}
