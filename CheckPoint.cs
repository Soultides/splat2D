using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public Transform SpawnPoint;

    private void Start()
    {
        Vector2 SP = new Vector2 (SpawnPoint.position.x, SpawnPoint.position.y);
    }
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.position = new Vector2(SpawnPoint.transform.position.x, SpawnPoint.transform.position.y); 
        }

    }
}
