//|*************************************|
//| NAME: Phu Pham                      |
//| ID: 101250748                       |
//|                                     |
//| Script: MainMenuButtonManager       |
//| Desc: Provides functionality for button in the mainmenu
//| Date last modified: 2/10/2021       |
//|*************************************|


using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuButtonManager : MonoBehaviour
{
    public void onPlayButtonClick()
    {
        SceneManager.LoadScene("PlayScene");
    }
    public void onOptionButtonClick()
    {
        //Add scene transition to option scene here
    }

    public void onQuitButtonClick()
    {
        Application.Quit();
    }
    public void onInstructionButtonClick()
    {
        SceneManager.LoadScene("InstructionScene");
    }
}
