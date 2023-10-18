using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float dodge;

    public KeyCode keyToDisable = KeyCode.Space;
    public float disableTime; // The time in seconds to disable the key
    private bool isKeyDisabled = false;
    private float disableTimer = 0.0f;
 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);

        transform.Translate(movementDirection * speed * Time.deltaTime);

        if (isKeyDisabled)
        {
            // Key is disabled, count down the timer
            disableTimer -= Time.deltaTime;

            // If the timer reaches 0 or less, re-enable the key
            if (disableTimer <= 0)
            {
                isKeyDisabled = false;
            }
        }
        else
        {
            // Key is not disabled, check if the key is pressed
            if (Input.GetKeyDown(keyToDisable))
            {
                GetComponent<Rigidbody>().AddForce(movementDirection * dodge, ForceMode.VelocityChange);

                // Key is pressed, disable it 

                isKeyDisabled = true;
                disableTimer = disableTime;
            }
        }
    }
}
