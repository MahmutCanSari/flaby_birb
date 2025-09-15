using UnityEngine;

public class pipe_spawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawn_rate = 6;
    public float y_offset = 5;
    private float timer = 0;
    void Start()
    {
        spawner();
    }

    void Update()
    {
        if (timer < spawn_rate)
        {
            timer = timer + Time.deltaTime; 
        }
        else
        {
            timer = 0;
            spawner();  
        }
    }

    void spawner()
    {
        float min = transform.position.y-y_offset;
        float max = transform.position.y+y_offset;

        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(min,max),0), transform.rotation);
    }
}
