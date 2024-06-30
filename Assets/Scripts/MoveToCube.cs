using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToCube : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < -10f)
            Destroy(gameObject);
        
    }
}
