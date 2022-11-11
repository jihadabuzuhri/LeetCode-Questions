using System;

public class Solution {
    
    public int RemoveDuplicates(int[] nums) {
        
        int i =0,j=1;
        
        while(j<nums.Length){
            if (nums[i]==nums[j]){
            j++;
            }
            else {
                i++;
                nums[i]=nums[j];
                j++;
            }
        }
        
        
        return i+1;

    }
}