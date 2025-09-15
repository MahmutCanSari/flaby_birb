using UnityEngine;

public class pipe_mov : MonoBehaviour
{
    public float speed = 3;
    public float die_zone = -12;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * speed * Time.deltaTime;
        
        if(transform.position.x < die_zone)
        {
            Destroy(gameObject);
        }
    }
}
