using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speed;
    public float enX;
    public float startX;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= enX)
        {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
    }
}
