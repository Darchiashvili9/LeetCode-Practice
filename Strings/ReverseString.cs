public class Solution {
    public void ReverseString(char[] s) {

        for(int i = 0 ; i<s.Length/2; i++)
        {
            char tmp = s[i];
            s[i] = s[s.Length - 1 - i];
            s[s.Length - 1 - i] = tmp;

        }

        foreach(var symb in s)
        {
            Console.WriteLine(symb);
        }
    }
}
var solver = new Solution();


char [] s = ['h','e','l','l','o'];


solver.ReverseString(s);