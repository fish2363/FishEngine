using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountingStar : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    private StarStorage starStorage;

    private void Awake()
    {
        starStorage = FindAnyObjectByType<StarStorage>();
    }

    private void Update()
    {
        if(starStorage.StarCount == 1)
        {
            text.text = "1";
        }
        else if(starStorage.StarCount == 2)
        {
            text.text = "2";
        }
        else if (starStorage.StarCount == 3)
        {
            text.text = "3";
        }
    }
}
