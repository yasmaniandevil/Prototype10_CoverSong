using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Vector2 targetPosition;
    public int speed = 2;
    public GameObject panelToActivate;
    public TextMeshProUGUI text;
    public TextMeshProUGUI nameText;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,
            targetPosition, speed * Time.deltaTime);

        if ((Vector2)transform.position == targetPosition)
        {
            StartCoroutine(ActivateTextThenPanel());
            this.enabled = false;
        }
        
    }

    private IEnumerator ActivateTextThenPanel()
    {
        text.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        
        text.gameObject.SetActive(false);
        panelToActivate.SetActive(true);
        nameText.gameObject.SetActive(true);
        
    }
    
}
