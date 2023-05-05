using UnityEngine;

public class TranslateDown : MonoBehaviour
{
    public Transform target;
    public float speed = 10f;
    public bool translate = false;

    private void Update()
    {
        if (translate)
        {
            Vector3 motionVector = Vector3.down * (speed * Time.deltaTime);
            transform.Translate(motionVector, Space.World);
        }
    }

    public void StartMotion()
    {
        translate = true;
    }
}