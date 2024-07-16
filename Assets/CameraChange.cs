using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraChange : MonoBehaviour
{
    public bool rollBack;

    public GameObject block;

    [SerializeField]
    private CinemachineVirtualCamera currentCam;

    [SerializeField]
    private CinemachineVirtualCamera changeCam;

    private StarShooter starShooter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (block != null)
            block.SetActive(true);

        if(collision.CompareTag("Player"))
        {
            if(rollBack)
            {
                currentCam.gameObject.SetActive(true);
                changeCam.gameObject.SetActive(false);
            }
            else
            {
                currentCam.gameObject.SetActive(false);
                changeCam.gameObject.SetActive(true);
            }
        }
    }
}
