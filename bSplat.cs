using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bSplat : MonoBehaviour
{

    public float minSizeMod = 1f;
    public float maxSizeMod = 2f;

    void Start()
    {
        SetSize();
    }

    private void SetSize()
    {
        float sizeMod = Random.Range(minSizeMod, maxSizeMod);
        transform.localScale *= sizeMod;
    }
}
