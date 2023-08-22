using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowUpGenerator : MonoBehaviour
{
    public GameObject arrowupPrefab;
    float span = 0.333f;
    float delta = 0;
     
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowupPrefab);
            float py = Random.Range(-8.0f, 8.0f);
            go.transform.position = new Vector3(py, -6, 0);
        }
    }
}
