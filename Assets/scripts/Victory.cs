using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //So you can use SceneManager

public class Victory : MonoBehaviour
{
    public GameObject aliens;
    public GameObject player;
    private bool ended;

    void Update()
    {
        Vector3 screenPos;
        foreach (Transform alien in aliens.transform)
        {
            screenPos = Camera.main.WorldToScreenPoint(alien.transform.position);
            if (screenPos.y < 0)
            {
                gameObject.GetComponent<Text>().text = "Vitória dos Aliens - Aperte R para restart";
                this.ended = true;

            }
        }
        if (player == null)
        {
            gameObject.GetComponent<Text>().text = "Vitória dos Aliens - Aperte R para restart";
            this.ended = true;
        }


        else if (aliens.transform.childCount == 0)
        {
            gameObject.GetComponent<Text>().text = "Vitória do Jogador - Aperte R para restart";
            this.ended = true;

        }
        if (Input.GetKeyDown("r") && this.ended)
        { //If you press R
            SceneManager.LoadScene("SampleScene"); //Load scene called Game
        }
    }
}
