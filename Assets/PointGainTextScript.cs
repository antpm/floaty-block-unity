using UnityEngine;
using UnityEngine.UIElements;

public class PointGainTextScript : MonoBehaviour
{
    public int duration = 1;
    private float lifeTime = 0;
    public int speed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.SetParent(GameObject.Find("FloatingTextCanvas").transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed *  Time.deltaTime);
        if (lifeTime >= duration)
        {
            Destroy(gameObject);
            
        }
        else
        {
            lifeTime += 1 * Time.deltaTime;
        }
    }
}
