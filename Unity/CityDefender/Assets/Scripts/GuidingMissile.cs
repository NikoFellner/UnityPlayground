using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuidingMissile : MonoBehaviour
{
    public float _movSpeed;
    public GameObject _explosionPrefab;

    private Rigidbody2D _rb;
    public Tank _tank;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _tank = FindObjectOfType<Tank>();
    }

    void FixedUpdate()
    {
        //TODO: Fly toward mouse-------------------------------
        Vector3 _movDir = transform.position + (_tank.GetMousePosition() - transform.position).normalized * _movSpeed * Time.deltaTime;
        _rb.MovePosition(_movDir);
        //-------------------------------------------------------------------
    }

    //When colliding with Enemy explode and kill everything around the missile
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemies")
        {
            Destroy(gameObject);
            Collider2D[] collidersInArea = Physics2D.OverlapCircleAll(transform.position, 3);
            foreach (Collider2D collider in collidersInArea)
            {
                if (collider.tag == "Enemies")
                {
                    Destroy(collider.gameObject);
                }
            }
            Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
        }
    }

    private Vector3 GetMousePos()
    {
        //Wandelt Mausposition in Weltkoordinaten mit einem Abstand von 10m zur Kamera entlang der Z-Achse(-> Z-Pos = 0)
        return Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10);
    }
}
