using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Enemy1 : Enemies
{

    public TextMeshProUGUI text1;
    public string[] sentances;
    private int index;
    public float typingSpeed;
    public GameObject[] haters;
    
    //public GameObject text;
    
    // Start is called before the first frame update
    void Start()
    {
        if (text1 == true)
        {
            StartCoroutine(Type());
        }
    }

    // Update is called once per frame
    void Update()
    {
        //get the direction from the enemy to the player
        Vector2 playerDirection = GameObject.FindWithTag("Player").transform.position - transform.position;

        //Debug.Log("Enemy Position" + transform.position);
        //Debug.Log("Player Direction: " + playerDirection.normalized);

        //create a raycast hit variable
        RaycastHit2D hit;

        //perform 2D raycast
        hit = Physics2D.Raycast(transform.position, playerDirection.normalized,
            detectionDistance, playerLayer);

        //Debug.Log("Raycast hit: " + hit.collider);
        //Debug.Log(gameObject.name);

        //when the raycast hits the player set text active to true
        if (hit.collider != null && hit.collider.CompareTag("Player"))
        {
            Debug.Log("player detected");
            text1.gameObject.SetActive(true);
            canvas.gameObject.SetActive(false);
            //haters.
            
            //call next sentence when enter is pressed but only when it hits the raycast
            if (Input.GetKey(KeyCode.Return))
            {
                NextSentence();
            }
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in sentances[index].ToCharArray())
        {
            text1.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        //if e is pressed
        //check to see if the index is less than the length of the array minus 1
        //if it is continue through the index
        
        Debug.Log("E is pressed");
        if (index < sentances.Length - 1)
        {
            index++;
            text1.text = "";
            StartCoroutine(Type());
        }
        else
        {
            text1.text = "";
        }
        
    }
}
