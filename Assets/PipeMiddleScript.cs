using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicManagerScript logic;
    public TextMeshProUGUI pointGainText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
            Instantiate(pointGainText, transform.position, transform.rotation);
            
        }
        
    }
}
