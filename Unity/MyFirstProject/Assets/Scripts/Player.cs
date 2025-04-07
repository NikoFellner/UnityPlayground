using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public UIManager _uiManager;

    public AudioClip _victorySound;
    public AudioClip _shootingSound;
    public AudioSource _goalSFX;

    public GameObject victoryText;
    private Rigidbody2D _rb;

    public float pushForce = 500f;
    public float moveSpeed = 5.0f;

    public float _shootingCooldown;
    private float _shootTimer;

    public GameObject diamondPref;
    // Start is called before the first frame update
    private void Awake()
    {
        _shootTimer = 2.0f;
    }
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _shootTimer += Time.deltaTime;
        _uiManager.UpdateShootCD(_shootTimer / _shootingCooldown);
        if (Input.GetKeyDown(KeyCode.Space) && _shootTimer > _shootingCooldown)
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        if (_shootTimer > _shootingCooldown)
        {
            _shootTimer = 0;
            Vector3 spawnPos = transform.position + new Vector3(0, 0.5f, 0);
            GameObject newDiamond = Instantiate(diamondPref, spawnPos, Quaternion.identity);
            Rigidbody2D rbDiamond = newDiamond.GetComponent<Rigidbody2D>();
            rbDiamond.AddForce(new Vector2(0, pushForce));
            _goalSFX.PlayOneShot(_shootingSound);
        }
    }
    void FixedUpdate()
    {
        float horzInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horzInput, vertInput, 0);
        Vector3 newPos =  transform.position + direction * moveSpeed * Time.deltaTime;
        _rb.MovePosition(newPos);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otherGO = collision.gameObject;
        if (otherGO.tag == "Killer")
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherGO = collision.gameObject;
        if (otherGO.tag == "Goal")
        {
            _goalSFX.PlayOneShot(_victorySound);
            victoryText.SetActive(true);
            Destroy(otherGO);

            SceneManager.LoadScene("Level2");
        }
    }
}

