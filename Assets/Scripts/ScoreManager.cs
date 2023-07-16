using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreDispley;

    private void Update()
    {
        scoreDispley.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Gear"))
        {
            score++;
        }
    }
}
