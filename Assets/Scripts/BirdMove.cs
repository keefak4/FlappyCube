using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class BirdMove : MonoBehaviour
{
    [SerializeField] private Vector3 _sPosition;
    [SerializeField] private float _speedCube;
    [SerializeField] private float _powerClick;
    [SerializeField] private float _rotaionsC;
    [SerializeField] private float _maxRotaionsZ;
    [SerializeField] private float _minRotionsZ;

    private Rigidbody2D _rigidbody2d;
    private Quaternion _maxrotat;
    private Quaternion _minrotat;
    private void Start()
    {       
        _rigidbody2d = GetComponent<Rigidbody2D>();
        _maxrotat = Quaternion.Euler(0, 0, _maxRotaionsZ);
        _minrotat = Quaternion.Euler(0, 0, _minRotionsZ);
        Reset();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2d.velocity = new Vector2(_speedCube, 0);
            transform.rotation = _maxrotat;
            _rigidbody2d.AddForce(Vector2.up * _powerClick, ForceMode2D.Force);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, _minrotat, _speedCube * Time.deltaTime);
    }
    public void Reset()
    {
        transform.position = _sPosition;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        _rigidbody2d.velocity = Vector2.zero;

    }
}
