using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject _objectToSpawn;
    public float _spawnInterval;

    private float _time;

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;

        if ( _time > _spawnInterval)
        {
            Instantiate(_objectToSpawn, transform.position, Quaternion.identity);
            _time = 0;
        }
    }
}
