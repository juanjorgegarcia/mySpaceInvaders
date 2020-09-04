using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 5f;
    private float bound = 9;
    private Vector3 position;
    private Vector3 screenSize;
    public GameObject bullet;
    public float wait = 0.3f;
    private float timer = 0;
    private int hp = 3;
    public AudioSource source;
    private int alliensKilled = 0;


    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        if (this.hp <= 0)
        {
            Destroy(gameObject);

        }

        timer += Time.deltaTime;
        if (timer > wait && Input.GetButton("Fire1"))
        {
            timer = 0;
            Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
            source.Play();

        }
        float dh = Input.GetAxis("Horizontal");
        if ((gameObject.transform.position.x > -bound || dh > 0) &&
            (gameObject.transform.position.x < bound || dh < 0))
        {
            position += Vector3.right * dh * speed * Time.deltaTime;
        }


        if (Input.GetAxis("Mouse X") != 0)
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position.x = worldPosition.x;
        }

        if (position.x < -bound)
        {
            position.x = -bound;
        }
        else if (position.x > bound)
        {
            position.x = bound;
        }

        transform.position = position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "BulletAlan")
        {
            this.hp--;

        }
    }
    public int getHP()
    {
        return this.hp;
    }
    public int getAlliensKilled()
    {
        return this.alliensKilled;
    }
    public void setAlliensKilled(int n)
    {
        this.alliensKilled = n;
    }



}
