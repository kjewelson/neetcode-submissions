public class Solution {

    public string Encode(IList<string> strs) {
        
        StringBuilder sb = new ();
        foreach(string item in strs)
        {
            sb.Append(new string(item.Reverse().ToArray()) + "-jew-");
        }
        // Console.WriteLine($"encoded string: {sb.ToString()}");
        return sb.ToString();
    }

    public List<string> Decode(string s) {

        var parts = s.Split("-jew-");

        return parts
            .Take(parts.Length - 1)
            .Select(e => new string(e.Reverse().ToArray()))
            .ToList();
   }
}
