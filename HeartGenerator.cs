using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class HeartGenerator : MonoBehaviour
{
    public GameObject heartPrefab;

    float span = 5.0f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(heartPrefab);
            int py = Random.Range(-4, 4);
            go.transform.position = new Vector3(-10, py, 0);
        }
    }
}
