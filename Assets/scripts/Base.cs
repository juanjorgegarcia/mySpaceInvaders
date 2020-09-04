using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    // Start is called before the first frame update
    private int life = 3;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.life <= 0)
        {
            Destroy(gameObject);

        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Alien")
        {
            Destroy(gameObject);

        }
        if (collision.tag == "Bullet")
        {
            this.life--;
            Destroy(collision.gameObject);

        }
    }
}
