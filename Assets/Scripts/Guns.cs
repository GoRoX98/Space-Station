using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Guns : MonoBehaviour
{
    [Header("Main")]
    [SerializeField] private Sprite _gunSprite;
    [SerializeField] private GameObject _bullet;
    [SerializeField] protected bool _coreGun;
    [SerializeField] protected GameObject _target;
    [SerializeField] protected bool _isActive = false;

    public bool IsActive => _isActive;

    [Header("Lvl Progression")]
    [SerializeField] protected int CurrentLvl = 1;
    [SerializeField] private List<int> DmgProgression;
    [SerializeField] private List<float> SpeedProgression;
    [SerializeField] private List<float> RadiusProgression;
    [SerializeField] private List<int> UpgradeCost;
    protected int MaxLvl { get; } = 10;

    public enum DmgType
    {
        Point,
        Splash
    }
     
    [Header("Specifications")]
    [SerializeField] protected int Dmg;
    [SerializeField] protected float Speed;
    [SerializeField] protected DmgType TypeDmg;
    [SerializeField] protected float DmgRadius;
    [SerializeField] protected int BuildCost;

    private void Update()
    {
        
    }

    public void UpgradeGun()
    {
        if (CurrentLvl < MaxLvl)
            CurrentLvl += 1;
        
        Dmg = DmgProgression[CurrentLvl - 1];
        Speed = SpeedProgression[CurrentLvl - 1];
        if (TypeDmg == DmgType.Splash)
            DmgRadius = RadiusProgression[CurrentLvl - 1];
        
    }
}
