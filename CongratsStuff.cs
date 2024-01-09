using UnityEngine;
using UnityEngine.SceneManagement;

public class CongratsStuff : MonoBehaviour
{
    public string gameScreen;
    public void GameStarwqwffts()
    {
        SceneManager.LoadScene(gameScreen);
        Debug.Log("Moved Onto Scene " + gameScreen);
    }
}

