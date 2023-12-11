using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 20;
    [FormerlySerializedAs("healthTextPlayer")] public TextMeshProUGUI healthText;
    //public TextMeshProUGUI healthTextEnemy;

    private void Start()
    {
        healthText.text = "Health:" + maxHealth.ToString();
    }

    public void TakeDamage(int damageAmt)
    {
        maxHealth -= damageAmt;

        if (maxHealth < 0) maxHealth = 0;
        
        UpdateHealthText();

        if (maxHealth <= 0)
        {
            //Debug.Log("Player defeated");
        }
    }

    void UpdateHealthText()
    {
        healthText.text = "Health: " + maxHealth.ToString();
    }
}
