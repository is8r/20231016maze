using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //パーティクルを設定する
    public ParticleSystem particle;

    //クリアキャンバスを設定する
    public GameObject ClearCanvas;

    void OnTriggerEnter(Collider other)
    {
        //パーティクルを再生する
        particle.Play();

        //クリアのパネルを表示させる
        ClearCanvas.SendMessage("OnEnter");

        Destroy(gameObject);
    }
}
