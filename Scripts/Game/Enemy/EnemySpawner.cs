using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;

    [SerializeField]
    private float _minimumSpawnTime;

    [SerializeField]
    private float _maximumSpawnTime;

    private float _timeUntillSpawn;

    //private bool _enemySpawned = false;//try

    void Awake()
    {
        SetTimeUntillSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        //if (_enemySpawned) return;//try
        _timeUntillSpawn -= Time.deltaTime;

        if (_timeUntillSpawn <= 0)
        {
            Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
            SetTimeUntillSpawn();
            //_enemySpawned = true; //try
        }

    }

   private void SetTimeUntillSpawn()
    {
        _timeUntillSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }
}
