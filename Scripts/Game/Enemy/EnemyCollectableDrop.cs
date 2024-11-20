using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollectableDrop : MonoBehaviour
{
    [SerializeField]
    private float _chanceOfCollectableDrop;

    private CollectableSpawner _collectableSpawner;

    private void Awake()
    {
        _collectableSpawner = FindObjectOfType<CollectableSpawner>();
    }

    public void RamdomlyDropCollection()
    {
        float random = Random.Range(0f, 1f);

        if(_chanceOfCollectableDrop >= random)
        {
            _collectableSpawner.SpawnCollectible(transform.position);
        }
    }
}
