using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _enemyPrefab;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private List<EnemyInfo> _enemyPatterns;
    [SerializeField] private int _wavePoints;
    [SerializeField] private int _complexityLvl;
    [SerializeField] private float _gameSpeed;

    private List<int> _enemyQueue;

    private void Start()
    {
        SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        GameObject enemyGO = Instantiate(_enemyPrefab, _spawner.GetRandomSpawn());
        Enemy enemy = enemyGO.AddComponent<Enemy>(); 
        enemy.Init(_enemyPatterns[0].GetData(1), 1);
    }
}
