using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Star : MonoBehaviour
{
    public Rigidbody2D rigidbodyCompo { get; private set; }
    public bool IsShooting { get; private set; } = false;
    public bool IsGetting { get; private set; } = false;
    public void Shoot(Vector2 shootDir, float shootPower)
    {
        rigidbodyCompo.velocity = shootDir * shootPower;
        IsShooting = true;
        StartCoroutine(ShootingCoroutine());
    }
    public void Get(StarGetter starGetter, StarStorage starStorage)
    {
        IsGetting = true;
        StartCoroutine(GetCoroutine(starGetter, starStorage));
        // this.transform.DOMove(starGetter.transform.position, starGetter._getTime).SetEase(Ease.InCubic).OnComplete(() =>
        // {
        //     starStorage.StoreStar(this);
        //     IsGetting = false;
        // });
    }
    private IEnumerator GetCoroutine(StarGetter starGetter, StarStorage starStorage)
    {
        float time = starGetter._getTime;
        float currenTime = 0;
        while (currenTime <= time)
        {
            currenTime += Time.deltaTime;
            float t = currenTime / time;
            transform.position = Vector3.Lerp(transform.position, starGetter.transform.position, t * t * t);
            yield return null;
        }
        starStorage.StoreStar(this);
        IsGetting = false;
    }

    private IEnumerator ShootingCoroutine()
    {
        yield return new WaitForSeconds(1f);
        IsShooting = false;
        // while(IsShooting)
        // {
        //     if(rigidbodyCompo.velocity.magnitude < 0.1f)
        //     {
        //         IsShooting = false;
        //         rigidbodyCompo.velocity = Vector2.zero;
        //     }
        //     yield return null;
        // }
    }

    private void Awake()
    {
        rigidbodyCompo = GetComponent<Rigidbody2D>();
    }
}
