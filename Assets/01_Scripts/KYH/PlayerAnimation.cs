using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    private PlayerInput playerInput;
    private SpriteRenderer spriteRenderer;
    private readonly int walkHash = Animator.StringToHash("Walk");
    private readonly int jumpHash = Animator.StringToHash("Jump");

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        playerInput = GameObject.Find("Player").GetComponent<PlayerInput>();
    }
    // Update is called once per frame
    void Update()
    {
        MoveAnimation();

        animator.SetBool(jumpHash, !playerInput.IsGround);
    }

    private void MoveAnimation()
    {
        if (playerInput.MoveDir.x != 0)
        {
            animator.SetBool(walkHash, true);
        }
        else
        {
            animator.SetBool(walkHash, false);
        }
    }
}
