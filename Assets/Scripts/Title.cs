using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    //Playボタンを押された時に実行される
    public void OnPlay()
    {
        //Mainシーンを呼び出す
        SceneManager.LoadScene("Main");
    }
}
