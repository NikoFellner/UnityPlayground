using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public float _hitForce;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionGO = collision.gameObject;
        Destroy(gameObject);
        if (collision.tag == "Killer")
        {
            Destroy(collisionGO);
        }

        Rigidbody2D _hitObject = collision.gameObject.GetComponent<Rigidbody2D>();
        Vector3 _hitDir = collision.transform.position - transform.position;
        _hitObject.AddForce(_hitDir.normalized * _hitForce, ForceMode2D.Impulse);
   
    }
}
