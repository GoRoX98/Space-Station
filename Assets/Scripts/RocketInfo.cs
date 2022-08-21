using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Rocket", menuName = "Gameplay/New rocket")]
public class RocketInfo : ScriptableObject
{
    [Header("Main")]
    [SerializeField] private Sprite _sprite;
    [SerializeField] protected GameObject _target;
    [SerializeField] protected bool _isActive = true;

    [Header("Specifications")]
    [SerializeField] protected int Dmg;
    [SerializeField] protected float Speed;
}
