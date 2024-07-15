using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarShooter : MonoBehaviour
{
    [SerializeField] StarStorage _starStorage;
    [SerializeField] float shootPower = 3f;
    private void Awake() {
        if (_starStorage == null)
            _starStorage = transform.parent.GetComponent<StarStorage>();
        if (_starStorage == null)
            Debug.LogError("StarShooter : StarStorage is null (ObjectName : " + transform.parent.name + ")");
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.F))
        {
            ShootStar();
        }
    }

    private void ShootStar()
    {
        Star star = _starStorage.TakeOutStar();
        if(star == null)
            return;
        star.transform.position = transform.position;
        Vector2 shootDir = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - star.transform.position).normalized;
        star.Shoot(shootDir, shootPower);
    }
}
