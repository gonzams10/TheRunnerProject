using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainMovement : MonoBehaviour
{
    [SerializeField] private Transform position;
    [SerializeField] private float terrainMovement;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * terrainMovement * Time.deltaTime;
    }
}
