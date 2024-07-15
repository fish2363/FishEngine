using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    private PlayerInput playerInput;
    private SpriteRenderer spriteRenderer;
    private readonly int walkHash = Animator.StringToHash("Walk");

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        playerInput = GameObject.Find("Player").GetComponent<PlayerInput>();
    }
    // Update is called once per frame
    void Update()
    {
        if(playerInput.MoveDir.x < 0)
        {
            spriteRenderer.flipX = true;
            animator.SetBool(walkHash, true);
        }
        else if (playerInput.MoveDir.magnitude > 0.1)
        {
            animator.SetBool(walkHash, true);
            spriteRenderer.flipX = false;
        }
        else
        {
            animator.SetBool(walkHash, false);
        }
    }
}
