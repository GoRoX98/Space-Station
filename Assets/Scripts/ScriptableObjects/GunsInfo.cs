using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public enum DmgType
    {
        Point,
        Splash
    }

[CreateAssetMenu(fileName = "Gun", menuName = "Gameplay/New gun")]
public class GunsInfo : ScriptableObject
{
    [Header("Main")]
    [SerializeField] private Sprite _gunSprite;
    [SerializeField] private GameObject _bullet;
    [SerializeField] protected bool _coreGun;
    [SerializeField] private int _maxLvl;


    [Header("Specifications")]
    [SerializeField] protected List<int> DmgProgression;
    [SerializeField] protected List<float> SpeedProgression;
    [SerializeField] protected List<float> DmgRadiusProgression;
    [SerializeField] protected List<int> UpgradeCost;
    [SerializeField] protected DmgType TypeDmg;

    public int GetDmg(int lvl) => DmgProgression[lvl];
    public float GetSpeed(int lvl) => SpeedProgression[lvl];
    public DmgType GetTypeDmg => TypeDmg;
    public int GetUpgradeCost(int nextLvl) => UpgradeCost[nextLvl];
    public float GetDmgRadius(int lvl) => DmgRadiusProgression[lvl];
}
