using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 점수에 관한 처리를 할 수 있도록 get set method를 만들자
// 1. SetScore() : 값을 넣고 UI text에 표시
// 2. GetScore() : 값 가져오기

public class ScoreManager : MonoBehaviour
{

    // 현재 스코어
    public int currentScore;

    // 최고 스코어
    public int bestScore;

    // 현재스코어 Text
    public Text currentScoreTxt;

    // 최고스코어 Text
    public Text bestScoreTxt;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("Best Score", 0);

        bestScoreTxt.text = "최고 점수 : " + bestScore;
    }


    //public void SetScore(int score)
    //{
    //    currentScore += score;

    //    // 4. UI Text에 current Score를 표시한다.
    //    currentScoreTxt.text = "현재 점수 : " + currentScore;

    //    if (currentScore > bestScore)
    //    {
    //        bestScore = currentScore;
    //        bestScoreTxt.text = "최고 점수 : " + bestScore.ToString();
    //    }

    //}

    public void SetScore(int value)
    {
        currentScore = value;

        // 4. UI Text에 current Score를 표시한다.
        currentScoreTxt.text = "현재 점수 : " + currentScore;

        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            bestScoreTxt.text = "최고 점수 : " + bestScore.ToString();
        }
    }

    public int GetScore()
    {
        return currentScore;
    }

}
