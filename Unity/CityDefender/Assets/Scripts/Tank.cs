using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float _movSpeed = 7;
    public GameObject _bulletPrefab;
    public GameObject _guidingMissilePrefab;
    public Transform _tankBarrel;
    public Transform _bulletSpawnPos;

    private Rigidbody2D _rb;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //TODO: On Left Mousebutton -> Shoot Bullet ---------------------------------
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_bulletPrefab, _bulletSpawnPos.position, Quaternion.identity);
        }

        //---------------------------------------------------------------------------
        else if (Input.GetMouseButtonDown(1))
        {            
            Instantiate(_guidingMissilePrefab, _bulletSpawnPos.position, Quaternion.identity);
        }
        

    }

    private void FixedUpdate()
    {
        //TODO: Move player by horMovement on X axis --------------------------------
        float horMovement = Input.GetAxis("Horizontal");
        //---------------------------------------------------------------------------
        Vector3 _moveVector = transform.position + new Vector3(horMovement, 0, 0) * _movSpeed * Time.deltaTime;
        _rb.MovePosition(_moveVector);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet" || collision.gameObject.tag == "Enemies")
            FindObjectOfType<GameManager>().LoseGame();
    }

    /// <summary>
    /// Calculate the Mouse Position in World-Coordinates
    /// </summary>
    /// <returns>Returns the position of the mouse in World-Coordinates</returns>
    public Vector3 GetMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10);
    }
}
