using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{   
    public float speed;
    Rigidbody2D RB;


    // Start is called before the first frame update
    void Start()
    {
        RB = this.GetComponent<Rigidbody2D>();
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Launch()
    {
        float direction = Random.Range(0,1);
        if (direction == 0f)
        {
            RB.velocity = new Vector2(-speed, 0);
        }
        else
        {
            RB.velocity = new Vector2(speed, 0);
        }
    }
}
