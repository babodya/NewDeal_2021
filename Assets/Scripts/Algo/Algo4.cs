using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  
    ��ȣ����
    ����(����)�� �ٸ� ���̰� �񱳸� �Ͽ�
    ������ ���� ����� ���� �� �ֵ��� �����ô�.
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

        //����
        for(int i = 0; i < height.Length; i++) // ���� �ε���
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
