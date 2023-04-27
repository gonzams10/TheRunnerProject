using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainMovement : MonoBehaviour
{
    [SerializeField] private Transform position;
    [SerializeField] private Transform Endposition;
    [SerializeField] private float moveSpeed;
    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    public void Move() 
    {
        var distanceVector = Endposition.position - transform.position;
        distanceVector.Normalize();
        transform.position += distanceVector *moveSpeed *Time.deltaTime;


    }


}
