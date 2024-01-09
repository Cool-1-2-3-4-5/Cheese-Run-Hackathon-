using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public string gameScreen;
    public float score = 0f;
    public void GameStarwqwffts()
    {
        SceneManager.LoadScene(gameScreen);
        Debug.Log("Moved Onto Scene " + gameScreen);
        PlayerPrefs.SetFloat("ScoreCnt", score);
        PlayerPrefs.Save();
    }
}
