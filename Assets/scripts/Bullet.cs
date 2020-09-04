using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    public int aliensKilled = 0;
    public Player player;
    public AudioClip clip;
    void Start()
    {
        player = FindObjectOfType<Player>().GetComponent<Player>();
        // player = GetComponent<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.up * speed * Time.deltaTime;
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Alien")
        {
            Destroy(collision.gameObject);
            player.setAlliensKilled(player.getAlliensKilled() + 1);
            AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, 0));
            Destroy(gameObject);

        }

    }


}
