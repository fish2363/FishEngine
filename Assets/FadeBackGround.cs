using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FadeBackGround : MonoBehaviour
{

    [SerializeField]
    private GameObject backGround;
    private SpriteRenderer[] backGroundImage;


    public GameObject block;

    private void Awake()
    {
        backGroundImage = backGround.GetComponentsInChildren<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (block != null)
            block.SetActive(true);

        if (collision.CompareTag("Player"))
        {
            for (int i = 0; i < backGroundImage.Length; i++)
                backGroundImage[i].DOFade(0, 1);
        }
    }
}
