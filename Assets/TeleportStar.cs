using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportStar : MonoBehaviour, IInterection
{
    [SerializeField]
    private Transform endTransform;
    [SerializeField]
    private Transform startTransform;
    private Transform playerTransform;
    private int inPortal =0;
    public GameObject[] inputBullun;//���� ��ǳ��

    private void Awake()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();

        //startTransform = GetComponent<Transform>();
        //endTransform = GetComponentInChildren<Transform>();

        inputBullun[0].SetActive(false);
        inputBullun[1].SetActive(false);
    }

    public void InputHelp()
    {
        inputBullun[inPortal].SetActive(true);
    }

    public void Interection()
    {
        print(inPortal);
        if(inPortal == 0)
        {
            playerTransform.position = endTransform.position;
            inPortal++;
            StartCoroutine(Wait());
<<<<<<< Updated upstream
=======
            for(int i = 0; i < starStorage.StarCount; i++)
            {
                Star star = starStorage.TakeOutStar();
                Destroy(star.gameObject);
            }
>>>>>>> Stashed changes
        }
        else if(inPortal ==1)
        {
            playerTransform.position = startTransform.position;
            inPortal--;
            StartCoroutine(Wait());
        }
        inputBullun[inPortal].SetActive(false);
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(1f);
    }

}
