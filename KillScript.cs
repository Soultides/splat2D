using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    public GameObject player;

    public Transform spawnPoint;
    public float spawnDelay = 1.5f;

    public ParticleSystem ps;
    AudioSource audioSource;
    public AudioClip death;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(death);
            player.SetActive(false);
            Instantiate(ps, collision.gameObject.transform.position, transform.rotation);
            StartCoroutine(Despawn(collision));
        }

    }

    public IEnumerator Despawn(Collider2D collision)
    {
        yield return new WaitForSeconds(spawnDelay);
        collision.gameObject.transform.position = spawnPoint.transform.position;
        player.SetActive(true);
    }

}
