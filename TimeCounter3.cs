using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCounter3 : MonoBehaviour
{
    GameObject Text;
    float time = 20.0f; //_Time;

    void Start()
    {
        this.Text = GameObject.Find("Text");
    }

    void Update()
    {
        this.time -= Time.deltaTime;
        if (this.time < 0)
        {
            this.Text.GetComponent<Text>().text = "ゲームクリア！";
            SceneManager.LoadScene("GameClearScene");
        }
        else
        {
            this.Text.GetComponent<Text>().text = this.time.ToString("F1");
        }
    }
}