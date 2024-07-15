using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindParticle : MonoBehaviour
{
    [SerializeField] public ParticleSystem ParticleSystemCompo { get; private set; }
    private void Awake()
    {
        ParticleSystemCompo = GetComponent<ParticleSystem>();
    }
    public void SetWindDir(Vector3 dir, float distance, float angle, float width, float power)
    {
        var shape = ParticleSystemCompo.shape;
        shape.scale = new Vector3(width, 1, 1);

        var startLifetime = ParticleSystemCompo.main.startLifetime;
        var ParticleSystemCompomain = ParticleSystemCompo.main;
        ParticleSystemCompomain.startLifetime = distance / power;

        var velocityOverLifetime = ParticleSystemCompo.velocityOverLifetime;
        // velocityOverLifetime.x = dir.x;
        velocityOverLifetime.y = power;
        // velocityOverLifetime.z = dir.z;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
