using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;
    public Text score;
    public Text playerHP;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerHP.text = "Life: " + player.getHP().ToString();

        score.text = "Score: " + player.getAlliensKilled().ToString();

    }
}
