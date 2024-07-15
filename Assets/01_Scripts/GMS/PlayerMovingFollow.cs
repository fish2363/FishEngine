using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovingFollow : MonoBehaviour
{

    [SerializeField] private Transform _playerTrm;
    void Update()
    {
        transform.position = Vector3.right * (_playerTrm.position.x - 5);
    }
}
