using UnityEngine;
using TMPro;
public class timer : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text up;
    public float start = 0f;
    // Update is called once per frame
    void FixedUpdate()
    {
        start += 1 * Time.deltaTime;
        up.text = start.ToString("0");
    }
}

