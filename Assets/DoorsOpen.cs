using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsOpen : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Open()
    {
        animator.SetBool("Open", true);
        gameObject.GetComponent<Collider2D>().enabled = false;
    }
}
