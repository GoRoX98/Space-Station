using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private RocketInfo _typeRocket;
    [SerializeField] private GameObject _target;

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
