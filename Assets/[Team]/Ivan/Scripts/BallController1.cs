using UnityEngine;
using Zinnia.Action;

public class BallController1 : MonoBehaviour
{
    public Rigidbody ballRigidbody;
    public float speed = 1f;

    public Vector2Action directionInput;
    

    void FixedUpdate()
    {
        directionInput = new Vector2Action();
        directionInput.Value = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        
        // float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 horizontalForce = Vector3.right * (directionInput.Value.x * speed);

        // float verticalInput = Input.GetAxis("Vertical");
        Vector3 verticalForce = Vector3.forward * (directionInput.Value.y * speed);

        Vector3 forceVector = horizontalForce + verticalForce;

        ballRigidbody.AddForce(forceVector);
    }
}