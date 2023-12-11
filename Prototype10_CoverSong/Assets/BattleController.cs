using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour
{
    
    private enum GameState
    {
       PlayerTurn, EnemyTurn, GameOver 
    }

    private GameState currentState;
    public PlayerHealth playerHealth;
    public PlayerHealth enemyHealth;
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentState = GameState.PlayerTurn;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentState == GameState.GameOver)
        {
            return;
            Debug.Log("Game Over");
        }
        else if (currentState == GameState.PlayerTurn)
        {
            
        }
        else if (currentState == GameState.EnemyTurn)
        {
            PerformEnemyAttach();
        }
    }

    public void OnPlayerAttack(int damage)
    {
        if (currentState != GameState.PlayerTurn) return;
        
        enemyHealth.TakeDamage(damage);
        if (enemyHealth.maxHealth <= 0)
        {
            currentState = GameState.GameOver;
            Debug.Log("player Defeated");
        }
        else
        {
            currentState = GameState.EnemyTurn;
        }
    }

    private void PerformEnemyAttach()
    {
        int damage = Random.Range(1, 5);
        playerHealth.TakeDamage(damage);

        if (playerHealth.maxHealth <= 0)
        {
            currentState = GameState.GameOver;
            Debug.Log("enemy Defeated");
        }
        else
        {
            currentState = GameState.PlayerTurn;
        }
    }
    
    public void TailWhip()
   {
       
   }

}
