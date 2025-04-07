using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleControl : MonoBehaviour
{
    public float movementSpeed = 1f;
    public int amplitude = 1;
    public bool horMovDir = true;
    public bool vertMovDir = true;
    private Vector3 direction;
    private float startXPos;
    private float startYPos;
     
    // Start is called before the first frame update
    void Start()
    {
        if (horMovDir && vertMovDir)
        {
            direction = new Vector3(1, 1, 0);
        }
        else if (horMovDir)
        {
            direction = new Vector3(1, 0, 0);
        }
        else if(vertMovDir)
        {
            direction = new Vector3(0, 1, 0);
        }
        startXPos = transform.position.x;
        startYPos = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float actualXPos = transform.position.x;
        float actualYPos = transform.position.y;
        double movedWay = System.Math.Sqrt(System.Math.Pow((actualXPos - startXPos),2)+ System.Math.Pow((actualYPos - startYPos), 2));        
        if (movedWay >= amplitude)
        {
            direction *= -1;
        }
        transform.position += direction*movementSpeed*Time.deltaTime;        
    }
}
