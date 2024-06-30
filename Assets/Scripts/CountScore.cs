using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountScore : MonoBehaviour
{
    public float score = 0f;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale > 0f)
        {
            score += 0.005f;
            text.text = ((int)score).ToString();
        }
        
    }
}
