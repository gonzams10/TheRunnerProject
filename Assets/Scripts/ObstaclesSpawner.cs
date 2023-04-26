using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{ 
    [SerializeField] Transform spawnPos;
    public GameObject _gonza;




    private void Update()
    {

        Instantiate(_gonza,spawnPos.position, spawnPos.rotation);


    }

}
