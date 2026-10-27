public class Solution {
    public int MaxProfit(int[] prices) {

        int low = prices[0];
        int high = prices[0];
        int diff = high - low;


        for(int i=1;i<prices.Length;i++)
        {
            Console.WriteLine($"low  = {low} , high = {high}");
            if(prices[i] < low && prices[i] < high && i != prices.Length-1)
            {
                low = prices[i];
                high = prices[i];
            }
            else if(prices[i] > high && prices[i] > low && prices[i] - low > diff )
            {
                high = prices[i];
                diff = high - low;
            }
            Console.WriteLine($"low change to = {low} , high change to = {high}");


        }

        return diff;

        
    }
}
