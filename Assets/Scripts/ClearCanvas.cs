using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ClearCanvas : MonoBehaviour
{
    //パネルを設定する
    public GameObject Panel;

    //パーティクルを設定する
    public ParticleSystem particle;

    //テキストを設定する
    public TMP_Text resultText;

    //再生した時に1回だけ実行される
    void Start()
    {
        //パネルを非表示にする
        Panel.SetActive(false);
    }

    //ゴールした時に外から呼ぶ命令
    public void OnEnter()
    {
        //パネルを表示する
        Panel.SetActive(true);

        //現在のスコアをロードする
        int score = PlayerPrefs.GetInt("score");

        //テキストエリアにその数字を代入します
        resultText.text = score.ToString();

        //パーティクルを再生する
        particle.Play();
    }

    public void OnReplay()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
