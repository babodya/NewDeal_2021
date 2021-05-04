using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  
    신호감지
    높이(숫자)가 다른 길이가 비교를 하여
    다음과 같은 결과가 나올 수 있도록 만들어봅시다.
    [5, 8, 3, 6, 9] => [0, 0, 2, 2, 0]
*/
public class Algo4 : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int[] temps = { 5, 8, 3, 6, 9 };
            int[] values = checked(temps);

            for(int i = 0; i <values.Length; i++)
            {
                print(values[i]); // [0, 0, 2, 2, 0]
            }
        }
    }

    int[] Check(int[] height)
    {
        int[] nums = new int[height.Length];

        //구현
        for(int i = 0; i < height.Length; i++) // 기준 인덱스
        {
            // 
            int j = i - 1;

            if(j < 0)
            {
                nums[i] = 0;
            }
        }


        return nums;

    }
}
