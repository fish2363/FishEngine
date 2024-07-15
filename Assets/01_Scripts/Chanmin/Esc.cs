using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Esc : MonoBehaviour
{
    public Button btb1;
    public Button btb2;
    public Image image;

    public void Restart()
    {
        image.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void Exit()
    {
        Application.Quit();
    }
}
