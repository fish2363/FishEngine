using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerInput playerInput;
    [SerializeField] private float moveSpeed;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    public void Update()
    {
        if (playerInput.MoveDir.x != 0)
        {
            playerInput.transform.localScale = new Vector3(playerInput.MoveDir.x, 1, 1);
            playerInput.rigid.velocity = new Vector2(playerInput.MoveDir.x * moveSpeed, playerInput.rigid.velocity.y);
        }
    }
}
