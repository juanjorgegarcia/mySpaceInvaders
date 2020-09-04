using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aliens : MonoBehaviour
{
    public float speed = 0.5f;
    public float wait = 0.4f;
    private bool invert = false;
    public GameObject bullet;
    private bool faster = false;

    void Start()
    {
        InvokeRepeating("AliensAttack", 0, wait);
    }

    void AliensAttack()
    {
        if (gameObject.transform.childCount <= 5 && !faster)
        {
            speed = speed * 2;
            faster = true;
        }
        if (invert)
        {
            speed = -speed;
            gameObject.transform.position += Vector3.down * Mathf.Abs(speed);
            invert = false;
            return;
        }
        else
        {
            gameObject.transform.position += Vector3.right * speed;
        }

        foreach (Transform alien in gameObject.transform)
        {
            if (alien.position.x < -9 || alien.position.x > 9)
            {
                invert = true;
                break;
            }
            if (Random.value < 0.02f)
            {
                Instantiate(bullet, alien.position, alien.rotation);
            }
        }

    }

}
