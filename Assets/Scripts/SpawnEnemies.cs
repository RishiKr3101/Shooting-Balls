using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour
{

    
    
    private Vector3 spawnPosition;

    public GameObject spriteToDuplicate;
    void Start()
    {

        Vector3 currentPosition = spriteToDuplicate.transform.position;
        for (int i = 0; i < 300; i++)
        {
            GameObject tmpObj = GameObject.Instantiate(spriteToDuplicate, currentPosition, Quaternion.identity) as GameObject;
            currentPosition = new Vector3(Random.Range(-100, 100), Random.Range(-1, 40), 0);
        }
    }

    

    private void Update()
    {
        
    }

}
