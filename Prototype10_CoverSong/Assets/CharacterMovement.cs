using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Vector2 targetPosition;
    public int speed = 2;

    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        //text.gameObject.SetActive(false);
        //Debug.Log();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position,
            targetPosition, speed * Time.deltaTime);
        
        
        //text.gameObject.SetActive(true);
        

    }
    
    /*if (originalPos == targetPosition)
        {
            text.gameObject.SetActive(true);
            Debug.Log("true");
        }*/
}
