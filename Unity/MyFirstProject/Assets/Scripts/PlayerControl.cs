using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float movementSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {      
        float directionHor = Input.GetAxis("Horizontal");
        float directionVer = Input.GetAxis("Vertical");
        transform.position += new Vector3(1,0,0) * movementSpeed * directionHor * Time.deltaTime;
        transform.position += new Vector3(0, 1, 0) * movementSpeed * directionVer * Time.deltaTime;

    }
}
