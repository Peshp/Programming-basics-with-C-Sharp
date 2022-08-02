using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace remove_extra_space_in_string                            

{
    class remove_space                                           
    {
        public void replace(string str1)                         
        {
            string pattern = "\\s+";
            string replacement = " ";                       
            Regex rx = new Regex(pattern);
            string result = rx.Replace(str1, replacement);  

            Console.WriteLine("Your string String          : {0}", str1);
            Console.WriteLine("Remove extra space String   : {0}", result);



        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string with extra space");

            string readstr = Console.ReadLine();
            remove_space rs = new remove_space();
            rs.replace(readstr);
        }
    }
}
