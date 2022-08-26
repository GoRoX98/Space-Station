using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Gameplay/New Enemy")]
public class EnemyInfo : ScriptableObject
{
    public enum EnemyType
    {
        Rocket,
        Bomb,
        Ship
    }

    public enum Effects
    {
        None,
        Freeze
    }

    [Header("Main")]
    [SerializeField] private Sprite _sprite;
    [SerializeField] private EnemyType _typeOfEnemy;
    [SerializeField] private Effects _effect = Effects.None;
    [SerializeField] private int _value;
    [SerializeField] private int _maxLvl;


    [Header("Specifications")]
    [SerializeField] protected List<int> HealthProgression;
    [SerializeField] protected List<int> DmgProgression;
    [SerializeField] protected List<float> SpeedProgression;

    public int GetMaxLvl => _maxLvl;
    public int GetValue => _value;
    public int GetHealth(int lvl) => HealthProgression[lvl];
    public int GetDmg(int lvl) => DmgProgression[lvl];
    public float GetSpeed(int lvl) => SpeedProgression[lvl];
    public EnemyType GetEnemyType => _typeOfEnemy;
    public Effects GetEffect => _effect;
}
