public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string,List<string>> kv = new();

        int[] count = new int[26];
        StringBuilder sb = new ();
        string key= "";

        foreach(var item in strs)
        {
            foreach(var ch in item)
            {
                count[ch-'a']++;
            }
            foreach(var ar in count)
            {
                sb.Append('#');
                sb.Append(ar);
            }

            // Console.WriteLine($"string : {sb.ToString()}");
            key=sb.ToString();
            sb=new();
            count=new int[26];
            
            if(kv.ContainsKey(key))
            {
                kv[key].Add(item);
            }
            else 
            {
                kv[key]= new List<string>();
                kv[key].Add(item);
            }

        }

        var result = kv.Values.ToList();


        return result;
    }
}
