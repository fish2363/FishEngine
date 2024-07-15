using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class EscManager : MonoBehaviour
{
    public Image image;

    public RectTransform rect;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            rect.DOAnchorPosY(-160, 0.1f).OnComplete(() => {
                Time.timeScale = 0;
            });

        }
    }
}
