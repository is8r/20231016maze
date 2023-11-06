using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    //数字の入れ物を作って0を入れておく
    int score = 0;

    public void OnScore(int num)
    {
        //入ってきた数値を加算する
        score += num;

        //TextMeshProのエリアに現在のscoreの値を表示する
        var scoreText = GetComponent<TMP_Text>();
        scoreText.text = score.ToString();

        //PlayerPrefsの中に保存
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.Save();
    }
}
