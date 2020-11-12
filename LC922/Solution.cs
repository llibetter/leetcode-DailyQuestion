/*
922. 按奇偶排序数组 II
给定一个非负整数数组 A， A 中一半整数是奇数，一半整数是偶数。

对数组进行排序，以便当 A[i] 为奇数时，i 也是奇数；当 A[i] 为偶数时， i 也是偶数。

你可以返回任何满足上述条件的数组作为答案。

 

示例：

输入：[4,2,5,7]
输出：[4,5,2,7]
解释：[4,7,2,5]，[2,5,4,7]，[2,7,4,5] 也会被接受。
*/

public class Solution {
    public int[] SortArrayByParityII(int[] A) {
        if(A==null||A.Length<2) return A;
        for(int i=0,j=1;i<A.Length;i+=2)
        {
            if(A[i]%2==0) continue;
            while(A[j]%2==1)
                j+=2;
            int tmp=A[i];
            A[i]=A[j];
            A[j]=tmp;
            j+=2;    
        }
        return A;
    }
}