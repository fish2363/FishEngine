using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float jumpForce = 10;

    public Vector2 MoveDir { get; private set; }
    public Rigidbody2D rigid;
    public static bool stop;
    public bool isGround;
    public event Action OnFire;

    [SerializeField]
    private LayerMask whatIsGround;
    [SerializeField]
    private Vector2 attackRadius;


    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Jump();

        if (!stop)
            MoveInput();

        GroundChecker();
    }

    private void GroundChecker()
    {
        isGround = Physics2D.OverlapBox(transform.position, attackRadius, whatIsGround); //하나 가져오기
    }

    private void MoveInput()
    {
        float x = Input.GetAxisRaw("Horizontal");

        MoveDir = new Vector2(x, 0);
        MoveDir = MoveDir.normalized;
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rigid.AddForce(jumpForce * Vector2.up, ForceMode2D.Impulse);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(transform.position, attackRadius);
    }
}
