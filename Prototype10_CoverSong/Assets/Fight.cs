using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Fight : MonoBehaviour
{

    [FormerlySerializedAs("panel")] public GameObject standardPanel;
    public GameObject fightPanel;
    
    
    
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
        standardPanel.SetActive(false);
        fightPanel.SetActive(true);
    }

   
    public void Leer()
    {
        
    }

    public void SmokeScreen()
    {
        
    }

    public void Return()
    {
        fightPanel.SetActive(false);
        standardPanel.SetActive(true);
    }
}
