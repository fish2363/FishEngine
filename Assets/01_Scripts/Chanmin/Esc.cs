using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Esc : MonoBehaviour
{
    public Button btb1;
    public Button btb2;
    public Image image;
    public RectTransform rect;

    public void Restart()
    {

        rect.DOAnchorPosY(1378, 0.1f);

        Time.timeScale = 1;
    }
    public void Exit()
    {
        Application.Quit();
    }
}
