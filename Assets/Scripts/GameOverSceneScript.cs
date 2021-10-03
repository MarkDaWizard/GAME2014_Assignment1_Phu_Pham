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
