using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class Enemy1 : Enemies
{

    public TextMeshProUGUI text1;
    public string[] sentances;
    private int index;
    public float typingSpeed;
    public GameObject[] haters;
    private bool isTyping = false;
    
    //public GameObject text;
    
    // Start is called before the first frame update
    void Start()
    {
        //check to see if text1 equals true
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
            //Debug.Log("player detected");
            text1.gameObject.SetActive(true);
            //canvas.gameObject.SetActive(false);
            SetHatersInactive();
            
            //call next sentence when enter is pressed but only when it hits the raycast
            if (Input.GetKey(KeyCode.Return))
            {
                NextSentence();
            }
        }
    }

    IEnumerator Type()
    {
        isTyping = true;
        foreach (char letter in sentances[index].ToCharArray())
        {
            text1.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        isTyping = false;
    }

    public void NextSentence()
    {
        if(isTyping)
            return;
        //if e is pressed
        //check to see if the index is less than the length of the array minus 1
        //if it is continue through the index
        
        //check to see if theres another sentence in the array
        //if(2 < the array length - 1) = 1
        if (index < sentances.Length - 1)
        {
            //move to the next sentence and reset text
            index++;
            text1.text = "";
            StartCoroutine(Type());
            Debug.Log("index:" + index);
        }
        //last sentence in array
        else if (index == sentances.Length - 2)
        {
            //index++;
            Debug.Log("second index:" + index);
            text1.text = "";
            StartCoroutine(Type());
            Debug.Log("Type");
        }
        //once all sentences displayed go to battle
        else
        {
            index++;
            GoToBattle();
            Debug.Log("Go to Battle");
        }
        
    }

    public void GoToBattle()
    {
        SceneManager.LoadScene("BattleScene1");
    }

    public void SetHatersInactive()
    {
        foreach (var hater in haters)
        {
            if (hater != null)
            {
                hater.SetActive(false);
            }
        }
    }
}
