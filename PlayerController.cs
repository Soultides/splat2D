using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PhysicsObject
{

    public bool canMove = true;
    public float jumpTakeOffSpeed = 7;
    public float doubleJumpSpeed = 7;
    public float maxSpeed = 7;
    public float wallSlideSpeedMax = 3;
    private bool m_FacingRight;
    
    private SpriteRenderer spriteRenderer;

    private bool canDoubleJump;

    public Vector2 wallLeap;

    public GameObject splatPrefab;
    public Transform splatSpawnG;
    public Transform splatSpawnW;

    public Animator animator;

    public bool powerUp;
    public float timer = 5f;
    public ParticleSystem splatPS;

    AudioSource audioSource;
    public AudioClip jump;
    public AudioClip poweredUp;

    void Start ()
    {
        audioSource = GetComponent<AudioSource>();

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {

        if(canMove == true)
        {
            void TrailG()
            {
                Instantiate(splatPrefab, splatSpawnG.position, splatSpawnG.rotation);
            }

            void TrailW()
            {
                Instantiate(splatPrefab, splatSpawnW.position, splatSpawnW.rotation);
            }

            if (grounded)
            {
                canDoubleJump = true;
                if (velocity.x != 0)
                {
                    TrailG();
                }
            }

            bool wallSliding = false;
            if (touchingWall && !grounded && velocity.y < 0)
            {
                wallSliding = true;

                if (velocity.y < -wallSlideSpeedMax)
                {
                    velocity.y = -wallSlideSpeedMax;
                    {
                        TrailW();
                    }
                }
            }

            if (velocity.x < 0 && !m_FacingRight) { Flip(); } else if (velocity.x > 0 && m_FacingRight) { Flip(); }

            Vector2 move = Vector2.zero;

            move.x = Input.GetAxis("horizontal");

            if (Input.GetButtonDown("jump"))
            {
                if (grounded)
                {
                    velocity.y = jumpTakeOffSpeed;
                    audioSource.PlayOneShot(jump);
                }
                else if (Input.GetButtonDown("jump") && canDoubleJump && !wallSliding)
                {
                    canDoubleJump = false;
                    velocity.y = doubleJumpSpeed;
                    audioSource.PlayOneShot(jump);
                }
                else if (wallSliding)
                {
                    velocity.y = wallLeap.y;
                    audioSource.PlayOneShot(jump);

                }
            }

            else if (Input.GetButtonUp("jump"))
            {
                if (velocity.y > 0)
                {
                    velocity.y = velocity.y * 0.5f;
                }
            }

            targetVelocity = move * maxSpeed;

            animator.SetFloat("JumpVel", velocity.y);
            animator.SetBool("Grounded", grounded);
            animator.SetBool("WallSliding", wallSliding);
        }
        

        if (powerUp == true)
        {

            audioSource.PlayOneShot(poweredUp);
            StartCoroutine(spawnPS());
            powerUp = false;

        }

    }


    private void Flip()
    {
        m_FacingRight = !m_FacingRight;
        Vector2 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private IEnumerator spawnPS()
    {
        while(timer > 0)
        {

            timer -= 1f;
            Instantiate(splatPS, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.5f);

        }

    }
}
