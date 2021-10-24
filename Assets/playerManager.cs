using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerManager : MonoBehaviour
{
    public Text playerCashText;
    public GameObject UIHeart2;
    public GameObject UIHeart3;
    public float playerLives = 3;
    public float playerCash = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerLives == 2)
        {
            UIHeart3.SetActive(false);
        }
        else if (playerLives == 1)
        {
            UIHeart2.SetActive(false);
        }
        else if (playerLives == 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }

        playerCashText.text = playerCash.ToString();   
    }

    public void onLiveLost()
    {
        playerLives--;
    }

    public void gainCash()
    {
        playerCash += 50f;
    }
       
    public void builtTower()
    {
        playerCash -= 100f;
    }

    public float getCash()
    {
        return playerCash;
    }
}
