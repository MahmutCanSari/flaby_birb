using UnityEngine;

public class Birdy_script : MonoBehaviour
{
    public Rigidbody2D my_body;
    public float flapines = 0;
    public logic_thingy logic;
    public bool birdIsalive = true;
    private bool down = false;
    private bool up = false;
    private bool isStarded = false;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_thingy>();
        Time.timeScale = 1;
    }
    void Update()
    {
        if (!isStarded)
        {
            Time.timeScale = 0;
         if(Input.touchCount > 0 && birdIsalive)
            {
                isStarded = true;
                Time.timeScale = 1;
            }   
        }
        if (Input.touchCount > 0 && birdIsalive)
        {
            my_body.linearVelocity = Vector2.up * flapines;
        }
        if (my_body.linearVelocity.y > 0)
        {
            if (!up)
            {
                transform.rotation = Quaternion.Euler(0, 0, 15);
                up = true;
                down = false;

            }
        }
        else if (my_body.linearVelocity.y < 0)
        {
            if (!down)
            {
                transform.rotation = Quaternion.Euler(0, 0, -15);
                up = false;
                down = true;

            }
        }
        if (transform.position.y < -10)
        {
            birdIsalive = false;
            logic.gameOver();
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsalive = false;
    }
}
