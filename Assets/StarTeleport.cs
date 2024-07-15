using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTeleport : MonoBehaviour
{

    [SerializeField]
    private Transform reSpawnTrans;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Star") || collision.CompareTag("Player"))
        {
            collision.transform.position = reSpawnTrans.position;
        }
    }

}
