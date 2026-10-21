public class Solution {
    public bool IsValid(string s) {
        Stack<char> stk = new();

        foreach (var ch in s) {
            if (ch == '(' || ch == '{' || ch == '[') 
                stk.Push(ch); 
            else if (ch == ')' && stk.Count() >0 && stk.Peek() == '(')
                stk.Pop();
            else if (ch == '}' && stk.Count() >0 && stk.Peek() == '{')
                stk.Pop();
            else if (ch == ']' && stk.Count() >0 && stk.Peek() == '[')
                stk.Pop();
            else 
                return false;
        }

        return stk.Count() == 0;
    }
}
