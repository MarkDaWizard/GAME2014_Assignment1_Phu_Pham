//|*************************************|
//| NAME: Phu Pham                      |
//| ID: 101250748                       |
//|                                     |
//| Script: TempReturnScript
//| Desc: A temporary script use for return player to main menu
//| Date last modified: 2/10/2021       |
//|*************************************|


using UnityEngine.SceneManagement;
using UnityEngine;

public class TempReturnScript : MonoBehaviour
{

    public void onReturnButtonClick()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void onOverButtonClick()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}



