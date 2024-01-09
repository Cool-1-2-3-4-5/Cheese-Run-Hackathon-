using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 setPosition;
    public float speed = 100f;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + setPosition;
        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.up, -speed * Time.deltaTime);
        }
    }
}


/*using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform player;  // The target object (the object the camera will follow)
    public float rotationSpeed = 2f;
    public float followSpeed = 5f;

    void Update()
    {
        // Rotate around the target
        
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.RotateAround(player.position, Vector3.up, rotationSpeed * horizontalInput * Time.deltaTime);

        // Follow the target
        Vector3 targetPosition = player.position - (transform.forward * 5f); // Adjust the multiplier for distance
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
    }
}*/
