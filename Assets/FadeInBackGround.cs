using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FadeInBackGround : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer backGroundImage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            backGroundImage.DOFade(1, 1);
        }
    }
}
