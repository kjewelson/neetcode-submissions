public class Solution {
    public int MaxArea(int[] heights) {

        int barCount = heights.Length;
        int left = 0;
        int right = barCount-1;
        int maxCap = 0;

        while(left < right)
        {
            int capacity = Math.Min(heights[left], heights[right]) * (right - left);
            maxCap = Math.Max(maxCap, capacity);
            if(heights[left] < heights[right])
                left++;
            else 
                right--;
        }

        return maxCap;
        
    }
}
