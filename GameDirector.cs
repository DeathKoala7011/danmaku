using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    float hpGaugeflag = 10;

    AudioSource[] sounds;

    public AudioClip[] clips = new AudioClip[2];

    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");

        sounds = GetComponents<AudioSource>();

    }

    void Update()
    {
        var hp = this.hpGauge;
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.2f;
        hpGaugeflag -= 2;

        sounds[0].PlayOneShot(clips[0]);

        if (hpGaugeflag == 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

    public void IncreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.2f;

        sounds[0].PlayOneShot(clips[1]);

        if (this.hpGauge.GetComponent<Image>().fillAmount > 1.0f)
        {
            this.hpGauge.GetComponent<Image>().fillAmount = 1.0f;
        }

        hpGaugeflag += 2;
        if (hpGaugeflag > 10)
        {
            hpGaugeflag = 10;
        }
    }
}
