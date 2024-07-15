using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    private PlayerInput playerInput;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidbody2DCompo;
    private readonly int walkHash = Animator.StringToHash("Walk");
    private readonly int jumpHash = Animator.StringToHash("Jump");
    private readonly int fallHash = Animator.StringToHash("Fall");

    private void Awake()
    {
        rigidbody2DCompo = transform.parent.GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        playerInput = GameObject.Find("Player").GetComponent<PlayerInput>();
    }
    // Update is called once per frame
    void Update()
    {
        // if(playerInput.MoveDir.x < 0)
        // {
        //     spriteRenderer.flipX = true;
        //     animator.SetBool(walkHash, true);
        // }
        // else if (playerInput.MoveDir.magnitude > 0.1)
        // {
        //     animator.SetBool(walkHash, true);
        //     spriteRenderer.flipX = false;
        // }
        if (playerInput.MoveDir.x != 0)
        {
            animator.SetBool(walkHash, true);
        }
        else
        {
            animator.SetBool(walkHash, false);
        }
        if (rigidbody2DCompo.velocity.y > 0.1f)
        {
            animator.SetBool(jumpHash, true);
            animator.SetBool(fallHash, false);
        }
        else if (rigidbody2DCompo.velocity.y < -0.05f)
        {
            animator.SetBool(jumpHash, false);
            animator.SetBool(fallHash, true);
        }
        else
        {
            animator.SetBool(jumpHash, false);
            animator.SetBool(fallHash, false);
        }
    }
}
