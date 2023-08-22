using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRightGenerator : MonoBehaviour
{
    public GameObject arrowrightPrefab;
    float span = 0.666f;
    float delta = 0;      

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowrightPrefab);
            float py = Random.Range(-4.0f, 4.0f);
            go.transform.position = new Vector3(-10, py, 0);
        }
    }
}