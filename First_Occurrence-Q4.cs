
public class Solution {
    
    public int StrStr(string haystack, string needle) {
        
        int i,j,k;  
        bool flag;
        
        for (i =0 ; i<=(haystack.Length-needle.Length);i++){
            flag=true;
            k=i;
            for (j =0 ; j<needle.Length;j++){
                
                if (haystack[k]==needle[j])
                    k++;
                
                else {
                flag=false;
                break;
                }
                
            }
            
            
            if (flag==true)
                return i;
                    
        }
        
        return -1;

        
    }
}