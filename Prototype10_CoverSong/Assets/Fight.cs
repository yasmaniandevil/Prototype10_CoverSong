using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Fight : MonoBehaviour
{

    public GameObject panel;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetActiveFight()
    {
        panel.gameObject.SetActive(false);
    }
}
