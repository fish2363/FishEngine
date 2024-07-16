using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovingFollow : MonoBehaviour
{

    [SerializeField] private Transform _playerTrm;
    void Update()
    {
        transform.position = new Vector3(_playerTrm.position.x - 4, 4,0);
    }
}
