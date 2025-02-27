using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public Transform target;
    public float transitionSpeed = 10; 

    private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Calculates how far the camera is from the target
        offset = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position - offset;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, transitionSpeed * Time.deltaTime);
    }
}
