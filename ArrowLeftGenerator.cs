using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowLeftGenerator : MonoBehaviour
{
    public GameObject arrowleftPrefab;
    float span = 0.75f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowleftPrefab);
            float py = Random.Range(-4.0f, 4.0f);
            go.transform.position = new Vector3(10, py, 0);
        }
    }
}
