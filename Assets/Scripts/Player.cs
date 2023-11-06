using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(1f, 40f)]
    public float speed = 10.0f;

    void FixedUpdate()
    {
        //横方向の入力の値を取得する
        float horizontal = Input.GetAxis("Horizontal");
        //縦方向の入力の値を取得する
        float vertical = Input.GetAxis("Vertical");

        //縦横の入力をまとめる
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        //Rigidbodyコンポーネントを取得する
        Rigidbody rb = GetComponent<Rigidbody>();

        //Rigidbodyコンポーネントに力を与える
        rb.AddForce(movement * speed);
    }
}
