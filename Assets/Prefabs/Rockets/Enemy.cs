using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string Name;
    [SerializeField] private GameObject _target;
    Sprite _sprite;

    private EnemyTypes _enemyType;
    private Effects _effect;
    private float _health;
    private float _damage;
    private float _speed;
    private int _value;

    public int RocketValue => _value;

    public Enemy(string name, EnemyTypes enemyType, Effects effect, float health, float damage, float speed, int value, Sprite sprite)
    {
        Name = name;
        _enemyType = enemyType;
        _effect = effect;
        _health = health;
        _damage = damage;
        _speed = speed;
        _value = value;
        _sprite = sprite;
    }

    private void Awake()
    {
        GetComponent<SpriteRenderer>().sprite = _sprite;
    }

    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        
    }

    private void Move()
    {

    }
}
