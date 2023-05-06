using UnityEngine;

public class Spinner1 : MonoBehaviour
{
    public float speed = 45f;
    
    void Update()
    {
        Vector3 rotationDelta = Vector3.up * speed * Time.deltaTime;
        transform.Rotate(rotationDelta, Space.World);
    }
}
