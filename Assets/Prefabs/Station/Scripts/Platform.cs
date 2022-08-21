using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Platform : MonoBehaviour
{
    [SerializeField] private GunsInfo _currentGun;
    [SerializeField] private List<GunsInfo> _gunList;

    private void Awake()
    {
        
    }
}
