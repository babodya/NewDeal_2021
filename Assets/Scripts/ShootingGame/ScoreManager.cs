using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ������ ���� ó���� �� �� �ֵ��� get set method�� ������
// 1. SetScore() : ���� �ְ� UI text�� ǥ��
// 2. GetScore() : �� ��������

public class ScoreManager : MonoBehaviour
{

    // ���� ���ھ�
    public int currentScore;

    // �ְ� ���ھ�
    public int bestScore;

    // ���罺�ھ� Text
    public Text currentScoreTxt;

    // �ְ��ھ� Text
    public Text bestScoreTxt;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("Best Score", 0);

        bestScoreTxt.text = "�ְ� ���� : " + bestScore;
    }


    //public void SetScore(int score)
    //{
    //    currentScore += score;

    //    // 4. UI Text�� current Score�� ǥ���Ѵ�.
    //    currentScoreTxt.text = "���� ���� : " + currentScore;

    //    if (currentScore > bestScore)
    //    {
    //        bestScore = currentScore;
    //        bestScoreTxt.text = "�ְ� ���� : " + bestScore.ToString();
    //    }

    //}

    public void SetScore(int value)
    {
        currentScore = value;

        // 4. UI Text�� current Score�� ǥ���Ѵ�.
        currentScoreTxt.text = "���� ���� : " + currentScore;

        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            bestScoreTxt.text = "�ְ� ���� : " + bestScore.ToString();
        }
    }

    public int GetScore()
    {
        return currentScore;
    }

}
