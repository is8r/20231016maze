using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    //プレイヤーを取得する
    public GameObject player;

    //カメラとプレイヤーの座標の差分を保持する
    Vector3 offset;

    //最初のフレームだけ実行される
    void Start()
    {
        //カメラとプレイヤーの座標の差分を計測
        offset = transform.position - player.transform.position;
    }

    //毎フレーム実行される
    void Update()
    {
        //カメラの位置をプレイヤーの位置+差分の座標に移動する
        transform.position = player.transform.position + offset;
    }
}
