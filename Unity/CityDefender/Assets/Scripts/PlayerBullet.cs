using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float _movSpeed = 7;
    private float _lifetime = 5;
    private Rigidbody2D _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //Destroy the Bullet after a few seconds
        _lifetime -= Time.deltaTime;
        if (_lifetime < 0)
            Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        //TODO: Move the Bullet upward---------------------------------------------------------
        _rb.MovePosition(transform.position + Vector3.up * _movSpeed * Time.deltaTime);
        //-------------------------------------------------------------------------------
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        //When colliding apply some additionalforce to the other Object
        Rigidbody2D otherRB = collision.gameObject.GetComponent<Rigidbody2D>();
        if (otherRB != null)
            otherRB.AddForceAtPosition(Vector2.up * 100, collision.contacts[0].point);

    }


}
