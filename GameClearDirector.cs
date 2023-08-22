using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearDirector : MonoBehaviour
{
    private void Start()
    {
        // ���ʉ��Đ�
        GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
