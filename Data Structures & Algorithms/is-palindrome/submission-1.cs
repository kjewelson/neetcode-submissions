public class Solution {
    public bool IsPalindrome(string s) {
        
        
        string str = "";

        foreach(var ch in s)
        {
            if(char.IsLetterOrDigit(ch))
            {
                str+=ch;
            }
        }

        str = str.ToLower();
        string rev = new string(str.Reverse().ToArray());
        // Console.WriteLine($"str is : {str} && reverse {str.Reverse().ToString()}");

    return str==rev;
    
    }
}
