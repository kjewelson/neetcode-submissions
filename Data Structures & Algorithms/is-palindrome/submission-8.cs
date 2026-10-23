public class Solution {
    public bool IsPalindrome(string s) {
        
        // string str = "";

        // foreach(var ch in s)
        // {
        //     if(char.IsLetterOrDigit(ch))
        //     {
        //         str+=ch;
        //     }
        // }

        // str = str.ToLower();
        // string rev = new string(str.Reverse().ToArray());
        // return str==rev;

        //Two Pointer

        int left = 0;
        int right = s.Length -1;

        while(left <= right)
        {

            if(!char.IsLetterOrDigit(s[left]))
                left++;
            else if(!char.IsLetterOrDigit(s[right]))
                right--;
            else
            {

            
            Console.WriteLine($"left : {char.ToLower(s[left])} , right : {char.ToLower(s[right])}");
            if(char.ToLower(s[left]) != char.ToLower(s[right]) && left <= right)
            {
                return false;
            }
            left++;
            right--;
            }
        }

        return true;
    
    }
}
