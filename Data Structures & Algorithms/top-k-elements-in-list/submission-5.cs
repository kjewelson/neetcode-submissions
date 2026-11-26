public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int,int> dict = new ();

        foreach(var item in nums)
        {
            if(dict.ContainsKey(item))
            {
                dict[item]++;
            }
            else
            {
                dict.Add(item,1);
            }
        }

        var result = dict.OrderByDescending(kv => kv.Value)
                        .Take(k)
                        .Select(kv=>kv.Key)
                        .ToArray();
        
        return result;

    }
}
