using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class Lever : MonoBehaviour , IInterection
{
    private Animator animator;
    public UnityEvent leverOnEvent;
    public GameObject inputBullun;//도움 말풍선
    private void Awake()
    {
        animator = GetComponent<Animator>();
        inputBullun.SetActive(false);
    }
    public void Interection()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        leverOnEvent?.Invoke();
        animator.SetBool("On", true);
        inputBullun.SetActive(false);
    }

    public void InputHelp()
    {
        Debug.Log("실행");
        inputBullun.SetActive(true);
    }

}
