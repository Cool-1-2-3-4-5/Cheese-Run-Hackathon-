using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public TMP_Text up;
    public TMP_Text dist;
    public Transform finish;
    public float distance = 0f;
    public float moveSpeed;
    public float rotationSpeed = 100f;
    public string gameScreen;
    public string final;
    public float time;
    void OnCollisionEnter(Collision player)
    {
        if (player.collider.name == final)
        {
            SceneManager.LoadScene(gameScreen);
            PlayerPrefs.SetFloat("My variable key", time);
            PlayerPrefs.Save();
        }
    }
    void Start()
    {
        time = 0f;
        moveSpeed = 6.5f;
}

    void FixedUpdate()
    {
        time += 1 * Time.deltaTime;
        float playerPositionX = transform.position.x;
        float playerPositionZ = transform.position.z;
        float linePositionX = finish.position.x;
        float linePositionZ = finish.position.z;
        distance = Mathf.Sqrt((Mathf.Abs(playerPositionX - linePositionX) * Mathf.Abs(playerPositionX - linePositionX)) + (Mathf.Abs(playerPositionZ - linePositionZ) * Mathf.Abs(playerPositionZ - linePositionZ)));
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        dist.text = distance.ToString("0");
        up.text = time.ToString("0");
    }
}

