using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarUI : MonoBehaviour
{
    [SerializeField] private GameObject[] stars = new GameObject[3];
    [SerializeField] private GameObject starPref;
    [SerializeField] private StarStorage starStorage;
    [SerializeField] private Transform ContentsTrm;
    private void Awake()
    {
        starStorage.StarCountChanged += StarCountChanged;
        for (int i = 0; i < 3; i++)
        {
            stars[i] = Instantiate(starPref, ContentsTrm);
        }
    }

    private void StarCountChanged(int obj)
    {
        for (int i = 0; i < stars.Length; i++)
        {
            Debug.Log(i);
            if (i < obj)
            {
                stars[i].SetActive(true);
            }
            else
            {
                stars[i].SetActive(false);
            }
        }
    }
}
