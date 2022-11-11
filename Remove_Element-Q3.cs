public class Solution {
 
    public int RemoveElement(int[] nums, int val) {
 

        int i =-1,j=0;
        
        while(j<nums.Length){
            if (nums[j]==val){
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

