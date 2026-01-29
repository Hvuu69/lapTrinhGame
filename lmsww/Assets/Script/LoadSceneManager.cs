using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
    public void LoadGameplay()
    {
        SceneManager.LoadScene("BattleScene");
        Debug.Log("CLICK");

    }

    public void LoadIntro()
    {
        SceneManager.LoadScene("C4");
        Debug.Log("CLICK");

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
