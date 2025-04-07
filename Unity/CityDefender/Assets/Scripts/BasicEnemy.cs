using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public float _movementSpeed = 3;

    private Rigidbody2D _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {

    }

    void FixedUpdate()
    {
        //TODO: Move Downward------------------------------------------------
        Vector3 _movDir = transform.position + Vector3.down * _movementSpeed * Time.deltaTime;
        _rb.MovePosition(_movDir);

        //-------------------------------------------------------------------
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Buildings")
        {
            Destroy(collision.gameObject);
        }
        else //If Enemy hits the ground or the Player show the Lose screen
        {
            //Find the GameManager in the scene
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager != null)
                gameManager.LoseGame();
        }
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            Destroy(gameObject);
        }
    }
}
