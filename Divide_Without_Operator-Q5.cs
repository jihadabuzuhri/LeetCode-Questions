
using System;

public class Solution {
    public int Divide(int dividend, int divisor) {
        
            int INT_MAX = 2147483647;
            int INT_MIN = -2147483648;

        
            if(dividend==INT_MIN && divisor==1)
            return INT_MIN;
                        
            if(dividend==INT_MIN && divisor==-1)
            return INT_MAX;
        
            if(dividend==INT_MAX && divisor==1)
            return INT_MAX;
                        
            if(dividend==INT_MAX && divisor==-1)
            return INT_MIN+1;
            
        
        
            int c=0;
        
            long a=dividend,b=divisor;
        
            if ( a<0 )
            a=-a;
            if ( b<0 )
            b=-b;
        
        
            while (a>=b){
                a-=b;
                c++;
            }
            
            if (  (dividend>0 && divisor>0)  || (dividend<0&&divisor<0) )
            return c;
            else
            return -c;
        
    }
}
