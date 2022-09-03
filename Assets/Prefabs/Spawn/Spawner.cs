using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private List<Transform> _spawnList;

    public Transform GetRandomSpawn()
    {
        return _spawnList[(int)Random.Range(0, _spawnList.Count - 1)];
    }
}
