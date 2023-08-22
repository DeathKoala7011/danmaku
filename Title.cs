using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // クリックされたら効果音が鳴る
            GetComponent<AudioSource>().Play();

            // ゲーム画面に移行する
            SceneManager.LoadScene("GameScene");
        }

    }
}