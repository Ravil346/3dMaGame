using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obj;
    private float[] randomY = {4.37f, 0.81f};
    Vector3 whereToSpawn;
    float spawnDelay;
    
    public float nextSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)  
        {
            spawnDelay = Random.Range(1.8f, 2.5f);
            nextSpawn = Time.time + spawnDelay;
            //var random = randomY[Random.Range(0, 2)];
            whereToSpawn = transform.position;
           // whereToSpawn.y = random;
            
            GameObject Enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);
            Enemy.transform.localScale = new Vector3(Random.Range(4f,6f), 0.5271519f, 1);
            

        } 
    }
}
