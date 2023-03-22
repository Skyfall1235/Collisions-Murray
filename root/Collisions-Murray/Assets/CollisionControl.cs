using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollisionControl : MonoBehaviour
{
    private Player player;
    [SerializeField] private TextMeshProUGUI playerValueText;
    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerValues();
        DisplayPlayerValues();
    }

    void StartGame()
    {
        player = new Player();
        player.PlayerHealth = 10;
        player.PlayerScore = 0;
    }

    void CheckPlayerValues()
    {
        if (player.PlayerHealth <= 0)
        {
            //end the game and allow the player to return
        }
        if (player.PlayerScore >= 10)
        {
            //end the game and allo wthe player to return, as a WINNER
        }
    }

    void DisplayPlayerValues()
    {
        playerValueText.text = $"HP:{player.PlayerHealth} \n Score:{player.PlayerScore}";
    }

    //collsion stuff
    private void OnCollisionEnter(Collision collision)
    {
        //does it really need to be complicated?

        if (collision.gameObject.tag == "Trap")
        {
            player.PlayerHealth -= 10;
        }
        if (collision.gameObject.tag == "Pickup")
        {
            player.PlayerScore += 1;
        }
    }
}
