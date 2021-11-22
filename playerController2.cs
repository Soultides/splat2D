using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : PhysicsObject
{

    public float jumpTakeOffSpeed = 7;
    public float doubleJumpSpeed = 7;
    public float maxSpeed = 7;

    private SpriteRenderer spriteRenderer;
    private bool canDoubleJump;

    public GameObject splatPrefab;
    public Transform splatSpawn;

    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Trail()
    {
        Instantiate(splatPrefab, splatSpawn.position, splatSpawn.rotation);
    }

    protected override void Computevelocity()
    {
        if (grounded)
        {
            canDoubleJump = true;
            if (velocity.x != 0)
            {
                Trail();
            }
        }

        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis("horizontal");

        if (Input.GetButtonDown("jump") && grounded)
        {

            velocity.y = jumpTakeOffSpeed;
        }
        else if (Input.GetButtonUp("jump"))
        {
            if (velocity.y > 0)
            {
                velocity.y = velocity.y * 0.5f;
            }

        }
        else if (Input.GetButtonDown("jump") && canDoubleJump)
        {
            canDoubleJump = false;
            velocity.y = doubleJumpSpeed;
        }
        else if (Input.GetButtonUp("jump"))
        {
            if (velocity.y > 0)
            {
                velocity.y = velocity.y * 0.5f;
            }
        }

        bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));
        if (flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }
        targetVelocity = move * maxSpeed;

    }
}
