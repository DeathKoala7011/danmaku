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
            // �N���b�N���ꂽ����ʉ�����
            GetComponent<AudioSource>().Play();

            // �Q�[����ʂɈڍs����
            SceneManager.LoadScene("GameScene");
        }

    }
}