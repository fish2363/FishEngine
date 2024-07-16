using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportStar : MonoBehaviour, IInterection
{
    [SerializeField]
    private Transform endTransform;
    [SerializeField]
    private Transform startTransform;
    private StarStorage starStorage;
    private Transform playerTransform;
    private int inPortal =0;
    public GameObject[] inputBullun;//���� ��ǳ��
    public bool deleteStar;

    private void Awake()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();

        //startTransform = GetComponent<Transform>();
        //endTransform = GetComponentInChildren<Transform>();
        starStorage = FindAnyObjectByType<StarStorage>();
        inputBullun[0].SetActive(false);
        inputBullun[1].SetActive(false);
    }

    public void InputHelp()
    {
        inputBullun[inPortal].SetActive(true);
    }

    public void Interection()
    {
        playerTransform.position = endTransform.position;
        StartCoroutine(Wait());
        for(int i = 0; i < starStorage.StarCount; i++)
        {
            if(deleteStar)
                starStorage._stars.Pop();
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(1f);
    }

}
