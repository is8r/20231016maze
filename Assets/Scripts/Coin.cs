using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //パーティクルを設定する
    public ParticleSystem particle;

    void Update()
    {
        //回転を加える
        transform.Rotate(0, 0, 2f);
    }

    //ぶつかった時に実行
    void OnTriggerEnter(Collider other)
    {
        //ScoreTextを取得する
        var ScoreText = GameObject.Find("ScoreText");

        //得点の加算のメッセージを送る
        ScoreText.SendMessage("OnScore", 1);

        //パーティクルを再生
        particle.Play();

        //自分自身を削除
        Destroy(gameObject);
    }
}
