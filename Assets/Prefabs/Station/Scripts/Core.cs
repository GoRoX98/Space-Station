using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    private int _health = 1;
    [SerializeField] private bool _isSelect;
    [SerializeField] private GunsInfo _currentGun;
    [SerializeField] private List<GunsInfo> _guns;
    [SerializeField] bool _isActive = true;

    [SerializeField] private List<Platform> _platforms;

    public bool Alive => _health > 0;

    private Vector3 _mousePosition;
    private Vector2 _direction;
    float _angle;

    private void Awake()
    {
        _currentGun = _guns[0];
    }

    private void Update()
    {
        if(_isSelect && _isActive)
        {
            _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _direction = _mousePosition - transform.position;
            _angle = Vector2.SignedAngle(Vector2.right, _direction);
            transform.eulerAngles = new Vector3(0, 0, _angle);
        }
    }
}
