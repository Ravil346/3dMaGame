using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        onPause();
    }

    // Update is called once per frame
    void Update()
    {
        if (obj.transform.position.y > 7f || obj.transform.position.y < -1f)
        {
            onPause();
        }
    }

    public void onPause()
    {
        Time.timeScale = 0f;
    }

    public void offPause()
    {
        Time.timeScale = 1f;
    }

    public void easy()
    {
        Time.timeScale = 1f;
    }

    public void middle()
    {
        Time.timeScale = 1.5f;

    }

    public void hard()
    {
        Time.timeScale = 1.8f;

    }

    public void ReStartGame()
    {
        SceneManager.LoadScene(0);
        
    }

}
