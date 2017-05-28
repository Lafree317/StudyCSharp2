using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * 
 * 
 *  
 *  1: 判断回文字符串。
        例如： rotor 就是回文字符串。
    2：请找出1－256中所有的回文数。
    
    4:统计文本行中单词的个数。
       例如： 输入“I am a student”
             则程序的运行结果输出为 ： 4个单词。

    5： 日期的常用格式具有如下两种：
       2003-11-29 和 十一 29,2003
      从键盘读入几行格式的日期，编程输出第二种格式的日期。
 * 
 * 
 */
namespace test2 {
    class StringClass{
        public void Start() {
            //strPalindrome();
            //numberPalindrome();// 1-265回文
            DataChangeFormat();
            Console.ReadLine();

        }

        // 字符串翻转
        private string ReverString(string str) {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--) {
                result += str.Substring(i, 1);
            }
            return result;
        }

        // 1: 判断回文字符串。
        // 例如： rotor 就是回文字符串。
        private void StrPalindrome() {
            while (true) {
                string str = Console.ReadLine();
                if (str == ReverString(str)) {
                    Console.WriteLine("是回文");
                } else {
                    Console.WriteLine("不是回文");
                }
            }
        }

        

        // 2：请找出1－256中所有的回文数。
        private void NumberPalindrome() {
            Console.WriteLine("1-265中的回文数为:");
            for(int i = 0; i < 256; i++) {
                var str = Convert.ToString(i);
                if (str == ReverString(str)) {
                    Console.WriteLine(str);
                }
            }
        }


        /**
            3: 写一个方法，对给定的Emall 字符串做检验。
            要求：  1）要求字符串中包含“@”字符与“.”字符。
                    2）要求字符串中@ 字符在 . 字符之前。
         */
        private void JudgeEmall() {
            string email = "lafree317@163.com";

            
            int intIndexPositionAt = -1;
            int intIndexPositionDot = -1;

            for (int i = 0; i < email.Length; i++) {
                string c = email.Substring(i, 1);
                if (c == "@") {
                    intIndexPositionAt = i;
                }else if(c == ".") {
                    intIndexPositionDot = i;
                }
            }

            bool bothHave = (intIndexPositionAt != -1) && (intIndexPositionDot != -1);
            if (bothHave && intIndexPositionAt < intIndexPositionDot) {
                Console.WriteLine("格式正确");
            } else {
                Console.WriteLine("格式不正确");
            }
        }

        /**
         *   4:统计文本行中单词的个数。
             例如： 输入“I am a student”
             则程序的运行结果输出为 ： 4个单词。
         */
        private void StrNumber() {
            // 根据空格切字符串
            string[] strs = "I am a student".Split(new string[] { " " }, StringSplitOptions.None);
            Console.WriteLine("单词的个数为:{0}", strs.Count<string>());
        }

        /*
         *  5： 日期的常用格式具有如下两种：
            2003-11-29 和 十一 29,2003
            从键盘读入几行格式的日期，编程输出第二种格式的日期。
         */
        private void DataChangeFormat() {
            string dataStr = "2003-11-29";
            string format = "yyyy-MM-dd";
            DateTime t = DateTime.ParseExact(dataStr, format, null);
            
            int month = Convert.ToInt32(t.Month.ToString());
            string monthStr = NumberToChinese(month);
            string dayYearStr = t.ToString(" dd,yyyy");
            Console.WriteLine(monthStr + dayYearStr);
        }
        // 数字转中文
        private string NumberToChinese(int number) {
            string result = "";
            switch (number) {
                case 1:
                    result = "一";
                    break;
                case 2:
                    result = "二";
                    break;
                case 3:
                    result = "三";
                    break;
                case 4:
                    result = "四";
                    break;
                case 5:
                    result = "五";
                    break;
                case 6:
                    result = "六";
                    break;
                case 7:
                    result = "七";
                    break;
                case 8:
                    result = "八";
                    break;
                case 9:
                    result = "九";
                    break;
                case 10:
                    result = "十";
                    break;
                case 11:
                    result = "十一";
                    break;
                case 12:
                    result = "十二";
                    break;
                
            }
            return result;
        }
    }




}
