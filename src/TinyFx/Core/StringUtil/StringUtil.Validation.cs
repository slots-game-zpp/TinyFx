﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TinyFx.Text;

namespace TinyFx
{
    /// <summary>
    /// 字符串操作静态辅助类
    /// </summary>
    public static partial class StringUtil
    {
        #region 网上找的常用正则

        /*
1.验证用户名和密码：（"^[a-zA-Z]\w{5,15}$"）正确格式："[A-Z][a-z]_[0-9]"组成,并且第一个字必须为字母6~16位；
2.验证电话号码：（"^(\\d{3,4}-)\\d{7,8}$"）正确格式：xxx/xxxx-xxxxxxx/xxxxxxxx；
3.验证手机号码："^1[3|4|5|7|8][0-9]\\d{8}$"；
4.验证身份证号（15位或18位数字）："\\d{14}[[0-9],0-9xX]"；
5.验证Email地址：("^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")；
6.只能输入由数字和26个英文字母组成的字符串：("^[A-Za-z0-9]+$") ;
7.整数或者小数：^[0-9]+([.][0-9]+){0,1}$
8.只能输入数字："^[0-9]*$"。
9.只能输入n位的数字："^\d{n}$"。
10.只能输入至少n位的数字："^\d{n,}$"。
11.只能输入m~n位的数字："^\d{m,n}$"。
12.只能输入零和非零开头的数字："^(0|[1-9][0-9]*)$"。
13.只能输入有两位小数的正实数："^[0-9]+(\.[0-9]{2})?$"。
14.只能输入有1~3位小数的正实数："^[0-9]+(\.[0-9]{1,3})?$"。
15.只能输入非零的正整数："^\+?[1-9][0-9]*$"。
16.只能输入非零的负整数："^\-[1-9][0-9]*$"。
17.只能输入长度为3的字符："^.{3}$"。
18.只能输入由26个英文字母组成的字符串："^[A-Za-z]+$"。
19.只能输入由26个大写英文字母组成的字符串："^[A-Z]+$"。
20.只能输入由26个小写英文字母组成的字符串："^[a-z]+$"。
21.验证是否含有^%&',;=?$\"等字符："[%&',;=?$\\^]+"。
22.只能输入汉字："^[\u4e00-\u9fa5]{0,}$"。
23.验证URL："^http://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$"。
24.验证一年的12个月："^(0?[1-9]|1[0-2])$"正确格式为："01"～"09"和"10"～"12"。
25.验证一个月的31天："^((0?[1-9])|((1|2)[0-9])|30|31)$"正确格式为；"01"～"09"、"10"～"29"和“30”~“31”。
26.获取日期正则表达式：\\d{4}[年|\-|\.]\d{\1-\12}[月|\-|\.]\d{\1-\31}日?
评注：可用来匹配大多数年月日信息。
27.匹配双字节字符(包括汉字在内)：[^\x00-\xff]
评注：可以用来计算字符串的长度（一个双字节字符长度计2，ASCII字符计1）
28.匹配空白行的正则表达式：\n\s*\r
评注：可以用来删除空白行
29.匹配HTML标记的正则表达式：<(\S*?)[^>]*>.*?</>|<.*? />
评注：网上流传的版本太糟糕，上面这个也仅仅能匹配部分，对于复杂的嵌套标记依旧无能为力
30.匹配首尾空白字符的正则表达式：^\s*|\s*$
评注：可以用来删除行首行尾的空白字符(包括空格、制表符、换页符等等)，非常有用的表达式
31.匹配网址URL的正则表达式：[a-zA-z]+://[^\s]*
评注：网上流传的版本功能很有限，上面这个基本可以满足需求
32.匹配帐号是否合法(字母开头，允许5-16字节，允许字母数字下划线)：^[a-zA-Z][a-zA-Z0-9_]{4,15}$
评注：表单验证时很实用
33.匹配腾讯QQ号：[1-9][0-9]{4,}
评注：腾讯QQ号从10 000 开始
34.匹配中国邮政编码：[1-9]\\d{5}(?!\d)
评注：中国邮政编码为6位数字
35.匹配ip地址：([1-9]{1,3}\.){3}[1-9]。
评注：提取ip地址时有用
36.匹配MAC地址：([A-Fa-f0-9]{2}\:){5}[A-Fa-f0-9]
        */

        #endregion

        /// <summary>
        /// 判断是否是中文汉字
        /// </summary>
        /// <param name="chr">需验证的字符</param>
        /// <returns></returns>
        public static bool IsChinese(char chr) => (chr >= 19968 && chr <= 40869);

        /// <summary>
        /// 判断字符串是否全是中文汉字
        /// </summary>
        /// <param name="text">需验证的字符串</param>
        /// <returns></returns>
        public static bool IsChinese(string text)
        {
            foreach (char chr in text)
            {
                if (!IsChinese(chr)) return false;
            }
            return true;
        }

        /// <summary>
        /// 验证是否是有效Email地址
        /// gmail规则：可包含(数字字母._-)，但._-不能开头结尾或连续
        /// </summary>
        /// <param name="email">需验证的字符串</param>
        /// <returns></returns>
        public static bool IsEmail(string email) // "^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"
        {
            if (string.IsNullOrEmpty(email))
                return false;
            var ret = Regex.IsMatch(email, @"^[a-z0-9A-Z]+[- | a-z0-9A-Z . _]+[a-z0-9A-Z]+@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (ret)
            {
                // 不能连续
                if (email.IndexOf("..") > 0 || email.IndexOf("__") > 0 || email.IndexOf("--") > 0)
                    return false;
            }
            return ret;
        }

        /// <summary>
        /// 验证是否是有效的电话号码
        /// </summary>
        /// <param name="telephone">需验证的字符串</param>
        /// <returns></returns>
        public static bool IsTelephone(string telephone)
            // ^(0\\d{2}-\\d{8}(-\\d{1,4})?)|(0\\d{3}-\\d{7,8}(-\\d{1,4})?)$
            => Regex.IsMatch(telephone, @"^(\\d{3,4}-)\\d{7,8}$");

        /// <summary>
        /// 验证是否是有效的手机号
        /// </summary>
        /// <param name="mobile">需验证的字符串</param>
        /// <returns></returns>
        public static bool IsMobile(string mobile)
            => Regex.IsMatch(mobile, @"^[1][3,4,5,6,7,8][0-9]{9}$");

        /// <summary>
        /// 验证是否是有效的IP地址
        /// </summary>
        /// <param name="ip">需验证的字符串</param>
        /// <returns></returns>
        public static bool IsIpAddress(string ip)
            => Regex.IsMatch(ip, @"^(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])$");

        /// <summary>
        /// 验证是否是有效地邮政编码
        /// </summary>
        /// <param name="postcode">需验证的字符串</param>
        /// <returns></returns>
        public static bool IsPostcode(string postcode)
            => Regex.IsMatch(postcode, @"[1-9]\d{5}(?!\d)");

        /// <summary>
        /// 验证是否是有效的URL
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool IsUrl(string url)
            => Regex.IsMatch(url, @"((http|ftp|https)://)(([a-zA-Z0-9\._-]+\.[a-zA-Z]{2,6})|([0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}))(:[0-9]{1,4})*(/[a-zA-Z0-9\&%_\./-~-]*)?");
        //=> Regex.IsMatch(url, @"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");

        /// <summary>
        /// 验证是否是非负数，包括正数和0
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNotNegativeNumber(string input)
            => Regex.IsMatch(input, @"^\d+[.]?\d*$");

        /// <summary>
        /// 验证是否是数字
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNumber(string input)
            => Regex.IsMatch(input, @"^[-]?\d+[.]?\d*$");

        /// <summary>
        /// 验证是否是非负整数，包括正整数和0
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNotNegativeInteger(string input)
            => Regex.IsMatch(input, @"^\d+$");

        /// <summary>
        /// 验证是否是整数
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsInteger(string input)
            => Regex.IsMatch(input, @"^-?\d+$");

        /// <summary>
        /// 验证是否是负整数
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNegativeInteger(string input)
            => Regex.IsMatch(input, @"^-[0-9]*[1-9][0-9]*$");

        /// <summary>
        /// 验证是否是正整数
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsPositiveInteger(string input)
            => Regex.IsMatch(input, @"^[0-9]*[1-9][0-9]*$");

        /// <summary>
        /// 验证是否是非正整数，包括负整数和0
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNotPositiveInteger(string input)
            => Regex.IsMatch(input, @"^((-\d+)|(0+))$");

        /// <summary>
        /// 验证是否是有效的身份证号
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsIDCard(string number)
            => IDCardInfo.IsValid(number);
    }
}
