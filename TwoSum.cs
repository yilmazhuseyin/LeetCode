public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Count(); i++)
    {
        int firstNumber = nums[i];
        int secondNumber = target - firstNumber;
        int secondNumberIndex = Array.IndexOf(nums, secondNumber);

        if (secondNumberIndex != -1 && secondNumberIndex != i) return new int[] { i, secondNumberIndex };
    }
    return new int[] { };
    }
}
