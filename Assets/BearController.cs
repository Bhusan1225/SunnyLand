using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearController : MonoBehaviour
{

    [Header ("Petrolling Point")]
    public Vector3 pointA;
    public Vector3 pointB;
    Vector3 TargetPoint;

    public float BearSpeed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = pointA;
        TargetPoint = pointB;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, TargetPoint, BearSpeed * Time.deltaTime);

        if (transform.position == TargetPoint) 
        {
            if (TargetPoint == pointA)
            {
                TargetPoint = pointB;
            }
            else 
            {
                TargetPoint = pointA;
            }
        }
            
    }
}
