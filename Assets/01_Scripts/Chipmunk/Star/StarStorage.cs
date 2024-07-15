using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarStorage : MonoBehaviour
{
    private Stack<Star> _stars = new();
    public Action<int> StarCountChanged;
    public int StarCount { get => _stars.Count + 1; }
    private void Start() {
        StarCountChanged?.Invoke(StarCount);
    }
    public void StoreStar(Star star)
    {
        _stars.Push(star);
        StarCountChanged?.Invoke(StarCount);
        star.gameObject.SetActive(false);
    }
    public Star TakeOutStar()
    {
        if(_stars.Count == 0)
        {
            Debug.LogWarning("StarStorage : Star is empty");
            return null;
        }
        Star star = _stars.Pop();
        star.trailRendererCompo.Clear();
        star.gameObject.SetActive(true);
        StarCountChanged?.Invoke(StarCount);
        return star;
    }
}
