using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    [SerializeField] private float _speed = 1.3f;
    [SerializeField] private float _width = 6f;

    private SpriteRenderer _renderer;
    private Vector2 _startingSize;

    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _startingSize = new Vector2(_renderer.size.x, _renderer.size.y);
    }

    void Update()
    {
        _renderer.size = new Vector2(_renderer.size.x + _speed * Time.deltaTime, _renderer.size.y);
        if (_renderer.size.x > _width)
        {
            _renderer.size = _startingSize;
        }
    }
}
