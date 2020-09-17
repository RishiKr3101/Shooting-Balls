using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour
{

    
    
    private Vector3 spawnPosition;

    public GameObject spriteToDuplicate;
    void Start()
    {

        Vector3 currentPosition = spriteToDuplicate.transform.position;
        for (int i = 0; i < 150; i++)
        {
            GameObject tmpObj = GameObject.Instantiate(spriteToDuplicate, currentPosition, Quaternion.identity) as GameObject;
            currentPosition = new Vector3(Random.Range(-99, 99), Random.Range(-1, 38), 0);
        }
    }

    

    private void Update()
    {
        
    }

}