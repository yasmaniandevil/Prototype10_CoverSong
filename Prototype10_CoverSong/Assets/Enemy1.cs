using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy1 : Enemies
{

    public TextMeshProUGUI text2;
    // Start is called before the first frame update
    void Start()
    {
        
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

        if (hit.collider != null && hit.collider.CompareTag("Player"))
        {
            Debug.Log("player detected");
            text2.gameObject.SetActive(true);
            //canvas.gameObject.SetActive(false);
            //button.SetActive(true);
        }
    }
}
