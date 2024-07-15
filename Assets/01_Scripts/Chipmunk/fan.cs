using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Wind : MonoBehaviour
{
    [SerializeField] float _fanPower = 10f;
    [SerializeField] float _width = 1f;
    [SerializeField] float distance;
    [SerializeField] ContactFilter2D _contactFilter;
    [field: SerializeField] public WindParticle WindParticleCompo { get; private set; }

    private void Awake()
    {
        WindParticleCompo.SetWindDir(transform.up, distance, transform.rotation.eulerAngles.z, _width, _fanPower);
    }
    private void OnValidate()
    {
        WindParticleCompo.SetWindDir(transform.up, distance, transform.rotation.eulerAngles.z, _width, _fanPower);

    }
    private void FixedUpdate()
    {
        List<Collider2D> results = Physics2D.OverlapBoxAll(transform.position + transform.up.normalized * distance / 2, new Vector2(_width, distance), 0, _contactFilter.layerMask).ToList();
        foreach (var item in results)
        {
            Debug.Log(item.name);
            Rigidbody2D rb = item.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Debug.Log("ald22");
                rb.velocity = transform.up * _fanPower;
            }
        }
    }
#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Vector2.up * distance / 2, new Vector2(_width, distance));
    }
#endif
}
