using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public Transform target;
    public float transitionSpeed = 10; 

    private Vector3 offset;

    
    void Start()
    {
        //Calculates how far the camera is from the target
        offset = target.position - transform.position;
    }

    void Update()
    {
        //check if player exists
        if (target == null)
        {
            enabled = false;
            return;
        }


        Vector3 targetPosition = target.position - offset;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, transitionSpeed * Time.deltaTime);
    }
}
