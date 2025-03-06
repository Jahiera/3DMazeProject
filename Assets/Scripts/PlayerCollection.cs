using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    
    //add scoring system here
    private void OnTriggerEnter(Collider other)
    {
        //if the object is TAGGED with "COLLECTABLE", then it is destroyed
        if (other.CompareTag("Collectable"))
        {
        Destroy(other.gameObject);
        }
    }
    
}
