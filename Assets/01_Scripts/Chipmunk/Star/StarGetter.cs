using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class StarGetter : MonoBehaviour
{
    [SerializeField] StarStorage _starStorage;
    [SerializeField] ContactFilter2D _contactFilter;
    [SerializeField] public float _getTime = 0.5f;
    [SerializeField] float _getRadius = 0.1f;
    private void Awake()
    {
        if (_starStorage == null)
            Debug.LogError("StarGetter : StarStorage is null (ObjectName : " + transform.parent.name + ")");
    }
    private void FixedUpdate()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, _getRadius, _contactFilter.layerMask);
        if (collider.Length == 0)
            return;
        foreach (var col in collider)
        {
            Star star = col.GetComponent<Star>();
            if (star != null && !star.IsShooting && !star.IsGetting)
            {
                star.Get(this, _starStorage);
            }
        }
    }
    #if UNITY_EDITOR
    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _getRadius);
    }
    #endif
}
