using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        player.PlayerHealth = 100;
        player.PlayerScore = 0;
    }

    void CheckPlayerValues()
    {
        if (player.PlayerHealth <= 0)
        {
            //end the game and allow the player to return
            SceneManager.LoadScene("LoseScene");
        }
        if (player.PlayerScore >= 10)
        {
            //end the game and allo wthe player to return, as a WINNER
            SceneManager.LoadScene("WinScene");
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
        Debug.Log("hitting something");
        if (collision.gameObject.tag == "Trap")
        {
            player.PlayerHealth -= 10;
            collision.gameObject.SetActive(false);
            Debug.Log("hitting a trap");
        }
        if (collision.gameObject.tag == "Pickup")
        {
            player.PlayerScore += 1;
            collision.gameObject.SetActive(false);
            Debug.Log("hitting a pickup");
        }
    }
}
