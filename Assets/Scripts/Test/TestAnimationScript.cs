using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimationScript : MonoBehaviour
{
    Animator animator;

    bool jumped = false;

    float jumptime = 0.0f;
    float stopJumpTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        animator = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetFloat("playerSpeed", 1.0f);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetFloat("playerSpeed", 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumped = true;
            animator.SetBool("jumped", true);

            Vector2 pos = transform.position;
            pos.y += 1.0f;

            transform.position = pos;
        }

        if (jumped)
        {
            jumptime += Time.deltaTime;

            if (jumptime >= stopJumpTime)
            {
                jumptime = 0;
                jumped = false;

                animator.SetBool("jumped", false);

                Vector2 pos = transform.position;
                pos.y -= 1.0f;

                transform.position = pos;
            }
        }
    }
}
