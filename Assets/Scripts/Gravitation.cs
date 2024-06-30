using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravitation : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        Physics.gravity = new Vector3(0f, -9.81f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && Input.mousePosition.y < 934f) // Если левая кнопка мыши нажата
        {
            Vector3 vector3 = Physics.gravity;
            vector3.y *= -1;
            Physics.gravity = vector3;
            Debug.Log(Input.mousePosition);
        }
    }
}
