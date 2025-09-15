using UnityEngine;

public class pipe_midle : MonoBehaviour
{
    public logic_thingy logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_thingy>();   
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addscore(1);
        }
    }
}
