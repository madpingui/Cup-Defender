using UnityEngine;

public class Balls : MonoBehaviour
{
    public Rigidbody2D rb;

    private float x;
    private float y = 5;

    public GameObject gameOver;

    void Start()
    {
        x = Random.Range(-5, 5);
        rb.velocity = new Vector2(x, y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
