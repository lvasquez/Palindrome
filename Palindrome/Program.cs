using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Palindrome
    {
        public bool IsPalindrome(string word)
        {
            string forward = "";
            string backward = "";
            bool r = false;

            foreach (char a in word.ToLower())
            {
                forward = forward + a.ToString();
                backward = a.ToString() + backward;

                if (forward == backward)
                    r = true;
                else
                    r = false;
            }
            return r;          
        }

        public static void Main(string[] args)
        {
            Palindrome ob = new Palindrome();
            Console.WriteLine(ob.IsPalindrome("Deleveled"));
        }
    }
}
