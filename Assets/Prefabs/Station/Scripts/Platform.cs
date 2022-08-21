using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Platform : MonoBehaviour
{
    [SerializeField] private Guns _currentGun;
    [SerializeField] private List<Guns> _gunList;

    private void Awake()
    {
        
    }
}
