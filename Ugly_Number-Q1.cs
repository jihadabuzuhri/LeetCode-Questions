
public class Solution {
    public bool IsUgly(int n) {

    if (n == 1)
        return true;
    if (n <= 0)
        return false;
 
    if (n % 2 == 0)
        return IsUgly(n / 2);
    if (n % 3 == 0)
        return IsUgly(n / 3);
    if (n % 5 == 0)
        return IsUgly(n / 5);
 
    return false;

        
    }
}