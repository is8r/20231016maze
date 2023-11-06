using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(1f, 40f)]
    public float speed = 10.0f;

    int goodCounter = 0;
    int badCounter = 0;

    [SerializeField] Material originalMaterial;
    [SerializeField] Material badMaterial;
    MeshRenderer meshRenderer;

    void Start()
    {
        TryGetComponent(out meshRenderer);
    }

    void FixedUpdate()
    {
        //横方向の入力の値を取得する
        float horizontal = Input.GetAxis("Horizontal");
        //縦方向の入力の値を取得する
        float vertical = Input.GetAxis("Vertical");

        //縦横の入力をまとめる
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        if (badCounter >= 0)
        {
            badCounter -= 1;

            movement *= -1;
        }
        else if (meshRenderer.material != originalMaterial)
        {
            meshRenderer.material = originalMaterial;
        }

        if (goodCounter >= 0)
        {
            goodCounter -= 1;

            transform.localScale = Vector3.one * 2.0f;
        }
        else if (transform.localScale != Vector3.one)
        {
            transform.localScale = Vector3.one;
        }

        //Rigidbodyコンポーネントを取得する
        Rigidbody rb = GetComponent<Rigidbody>();

        //Rigidbodyコンポーネントに力を与える
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("bad"))
        {
            badCounter = 100;

            meshRenderer.material = badMaterial;
        }

        if (other.name.Contains("good"))
        {
            goodCounter = 100;
        }
    }
}
