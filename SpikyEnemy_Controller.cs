using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikyEnemy_Controller : MonoBehaviour
{
    float sightRange = 10f;
    public float speed = 0.5f;

    public LayerMask playerLayerMask;

    private void FixedUpdate()
    {
        RaycastHit2D hit;

        if(Physics2D.Raycast(transform.position, transform.up * sightRange, sightRange, playerLayerMask))
        {
            hit = Physics2D.Raycast(transform.position, transform.up * sightRange, sightRange, playerLayerMask);
            transform.position = Vector3.Lerp(transform.position, hit.point, speed);
        }

        if (Physics2D.Raycast(transform.position, -transform.up * sightRange, sightRange, playerLayerMask))
        {
            hit = Physics2D.Raycast(transform.position, -transform.up * sightRange, sightRange, playerLayerMask);
            transform.position = Vector3.Lerp(transform.position, hit.point, speed);
        }

        if (Physics2D.Raycast(transform.position, transform.right * sightRange, sightRange, playerLayerMask))
        {
            hit = Physics2D.Raycast(transform.position, transform.right * sightRange, sightRange, playerLayerMask);
            transform.position = Vector3.Lerp(transform.position, hit.point, speed);
        }

        if (Physics2D.Raycast(transform.position, -transform.right * sightRange, sightRange, playerLayerMask))
        {
            hit = Physics2D.Raycast(transform.position, -transform.right * sightRange, sightRange, playerLayerMask);
            transform.position = Vector3.Lerp(transform.position, hit.point, speed);
        }

        else
        {
            Debug.Log("Not Player");
        }
    }
}
