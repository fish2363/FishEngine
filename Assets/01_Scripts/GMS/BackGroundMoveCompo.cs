using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMoveCompo : MonoBehaviour
{
    [SerializeField] private float _parallaxOffset;

    private SpriteRenderer _spriteRanderer;
    private Material _backGroundMat;

    private float _currentScroll;
    private float _ratio;

    private void Awake()
    {
        _spriteRanderer = GetComponent<SpriteRenderer>();
        _backGroundMat = _spriteRanderer.material;

        _ratio = 1f / _spriteRanderer.bounds.size.x;
    }
    private Transform _mainCamTrm;
    private float _beforePosition;

    private void Start()
    {
        _mainCamTrm = Camera.main.transform;
        _beforePosition = _mainCamTrm.position.x;
    }

    private void Update()
    {
        float delta = _mainCamTrm.position.x - _beforePosition;
        _beforePosition = _mainCamTrm.position.x;

        _currentScroll += delta * _parallaxOffset * _ratio;

        _backGroundMat.mainTextureOffset = new Vector2(_currentScroll, 0);
    }
}
