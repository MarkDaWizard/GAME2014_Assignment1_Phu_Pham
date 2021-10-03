//|*************************************|
//| NAME: Phu Pham                      |
//| ID: 101250748                       |
//|                                     |
//| Script: GameOverSceneScript         |
//| Date last modified: 2/10/2021       |
//|*************************************|


using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
public void onMenuButtonClick()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void onRetryButtonClick()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
