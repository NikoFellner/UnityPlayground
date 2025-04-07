using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrier : MonoBehaviour
{
    public GameObject _alienPrefab;
    public GameObject _enemyBulletPrefab;

    public float _shootCooldown = 2;

    private float _bulletTimer;

    private void Start()
    {

    }

    private void Update()
    {

        //TODO: Shoot EnemyBullets every few seconds-------------------------

        //-------------------------------------------------------------------
    }

    void FixedUpdate()
    {

        //TODO: Move slowly downward ----------------------------------------

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

            //TODO: Spawn Alien Prefabs on Death---------------------------------

            //-------------------------------------------------------------------

            //TODO: Carrier should be able to take 5 hits -----------------------


            //-------------------------------------------------------------------


            Destroy(gameObject);
        }
    }
}
