using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{

    bool playerMove;
    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();

        playerMove = FindObjectOfType<PlayerController>().canMove;

    }
    void Start()
    {

        playerMove = false;

        Invoke("FindExit", 2);

    }

    void FindExit()
    {

        anim.SetBool("Start", true);
        Invoke("Reset", 4);

    }

    private void Reset()
    {

        anim.SetBool("Start", false);
        playerMove = true;

    }
}
