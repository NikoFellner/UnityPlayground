using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public float _spawnInterval = 1;
    public GameObject _objToSpawn;
    float _timer = 1;

    private void Start()
    {
        _timer = _spawnInterval;
    }

    void Update()
    {
        _timer -= Time.deltaTime;
        if(_timer <= 0)
        {
            SpawnObject();
            _timer = _spawnInterval;
        }
        //20% more spawns every 10sec
        _spawnInterval -= (_spawnInterval * 0.2f) * (Time.deltaTime/10);
    }

    void SpawnObject()
    {
        //TODO: Spawn at random Positions -----------------------------------
        Vector3 _objToSpawnPos = new Vector3(Random.Range(1,20), 10, 0);

        Instantiate(_objToSpawn, _objToSpawnPos, Quaternion.identity);
        //-------------------------------------------------------------------

    }
}
