using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscManager : MonoBehaviour
{
    public Image image;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            image.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
