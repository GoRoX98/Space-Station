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

    public void Init(EnemyInfo info, int lvl)
    {
        Name = info.Name;
        _enemyType = info.EnemyType;
        _effect = info.Effect;
        _health = info.GetHealth(lvl);
        _damage = info.GetDmg(lvl);
        _speed = info.GetSpeed(lvl);
        _value = info.Value;
        _sprite = info.Sprite;
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
