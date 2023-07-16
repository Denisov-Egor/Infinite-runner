using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 tragePos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 5;
    public Text healthDisplay;
    public GameObject panel;

    void Update()
    {
        healthDisplay.text = health.ToString();

        if (health <= 0)
        {
            panel.SetActive(true);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, tragePos, speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight)
        {   
            tragePos = new Vector2(transform.position.x, transform.position.y+ Yincrement);
            transform.position = tragePos;
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight)
        {
            tragePos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = tragePos;
        }
    }
}
