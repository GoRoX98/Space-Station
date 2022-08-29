using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _enemyPrefab;
    [SerializeField] private List<GameObject> _spawnPoints;
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
        GameObject spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count - 1)];
        GameObject enemyGO = Instantiate(_enemyPrefab, spawnPoint.transform);
        Enemy enemy = enemyGO.AddComponent<Enemy>();
        enemy = _enemyPatterns[0].GetData(1);
    }
}
