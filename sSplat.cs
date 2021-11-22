using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sSplat : MonoBehaviour
{

    public float minSizeMod = 0.8f;
    public float maxSizeMod = 1.5f;
    private void Start()
    {
        SetSize();
    }

    private void SetSize()
    {
        float sizeMod = Random.Range(minSizeMod, maxSizeMod);
        transform.localScale *= sizeMod;
    }
}
