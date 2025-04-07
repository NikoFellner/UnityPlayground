using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float _movSpeed;
    public Vector3 _direction;

    private void Start()
    {
        CalcRandomDirection();
    }

    private void FixedUpdate()
    {
        //TODO: Move towards random Direction -------------------------------


        //-------------------------------------------------------------------
    }

    private void CalcRandomDirection()
    {
        //TODO: Calculate random Direction ---------------------------------


        _direction = new Vector3(0, -1, 0);
        //-------------------------------------------------------------------
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
