using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public enum Effects
    {
        None,
        Freeze
    }
    public enum EnemyTypes
    {
        Rocket,
        Bomb,
        Ship
    }

[CreateAssetMenu(fileName = "Enemy", menuName = "Gameplay/New Enemy")]
public class EnemyInfo : ScriptableObject
{
    [SerializeField] private string _enemyName;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private EnemyTypes _typeOfEnemy;
    [SerializeField] private Effects _effect = Effects.None;
    [SerializeField] private int _value;
    [SerializeField] private int _maxLvl;


    [SerializeField] protected List<float> HealthProgression;
    [SerializeField] protected List<float> DmgProgression;
    [SerializeField] protected List<float> SpeedProgression;
    [SerializeField] protected DmgType TypeOfDmg = DmgType.Point;
    [SerializeField] protected List<float> RadiusDmgProgression;

    public string Name => _enemyName;
    public int MaxLvl => _maxLvl;
    public int Value => _value;
    public float GetHealth(int lvl) => HealthProgression[lvl - 1];
    public float GetDmg(int lvl) => DmgProgression[lvl - 1];
    public float GetSpeed(int lvl) => SpeedProgression[lvl - 1];
    public EnemyTypes EnemyType => _typeOfEnemy;
    public Effects Effect => _effect;


    public Enemy GetData(int lvl)
    {
        Enemy newEnemy = new Enemy(_enemyName, _typeOfEnemy, _effect, GetHealth(lvl), GetDmg(lvl), GetSpeed(lvl), _value, _sprite);
        return newEnemy;
    }
}
