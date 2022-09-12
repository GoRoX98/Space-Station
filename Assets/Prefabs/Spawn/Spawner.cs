using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private List<Transform> _spawnList;

    public void GenerateSpawns(int count)
    {
        float angleStep = 360 / count;
        float angle = 0;
        for(int i = 0; i < count; i++)
        {
            
        }
    }

    public Transform GetRandomSpawn()
    {
        return _spawnList[(int)Random.Range(0, _spawnList.Count - 1)];
    }
}
