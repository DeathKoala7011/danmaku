using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using TMPro;

public class TimeCounter : MonoBehaviour
{
    //[SerializeField] private float _Time;
    //private TextMeshProUGUI text;

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
            this.Text.GetComponent<Text>().text = "ステージ1クリア！";
            SceneManager.LoadScene("GameScene2");
        }
        else
        {
            this.Text.GetComponent<Text>().text = this.time.ToString("F1");
        }
    }
}
