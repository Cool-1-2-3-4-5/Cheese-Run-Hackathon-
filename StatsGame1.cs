using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class StatsGame1 : MonoBehaviour
{
    public TMP_Text sec;
    public TMP_Text stats;
    void Start()
    {
        float time = PlayerPrefs.GetFloat("My variable key", 0f);
        sec.text = time.ToString("0");
        float score = PlayerPrefs.GetFloat("ScoreCnt", 0f);
        score += (10000 / time);
        PlayerPrefs.SetFloat("ScoreCnt", score);
        PlayerPrefs.Save();
        stats.text = score.ToString("0");
        Debug.Log(score);
    }
}
