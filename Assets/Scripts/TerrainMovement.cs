using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainMovement : MonoBehaviour
{
    [SerializeField] private Transform position;
    [SerializeField] public float terrainMovement;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * terrainMovement * Time.deltaTime;
    }
}
