//|*************************************|
//| NAME: Phu Pham                      |
//| ID: 101250748                       |
//|                                     |
//| Script: InstructionSceneScript      |
//| Date last modified: 2/10/2021       |
//|*************************************|

using UnityEngine.SceneManagement;
using UnityEngine;

public class InstructionSceneScript : MonoBehaviour
{
 public void onReturnButtonClick()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
