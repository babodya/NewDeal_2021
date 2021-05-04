using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindMidString : MonoBehaviour
{
    string tempA = "NewDeal";
    string tempB = "Deal";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            string middleword = PickMiddleWords(tempA);
            print(middleword);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            string middleword = PickMiddleWords(tempB);
            print(middleword);
        }
    }

    string PickMiddleWords(string word)
    {
        string middleWord = "";

        int num = word.Length / 2;

        if (word.Length % 2 == 0)
        {
            middleWord = word.Substring(num, 2);
        }
        else if(word.Length % 2 != 0)
        {
            middleWord = word.Substring(num, 1);
        }

        return middleWord;
    }

    // Update is called once per frame

}
