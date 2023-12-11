using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int screenWidth = Screen.width;
    int screenHeight = Screen.height;
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Screen Resolution: " + screenWidth + "x" + screenHeight);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("EnemyClasses");
        }
    }
}
