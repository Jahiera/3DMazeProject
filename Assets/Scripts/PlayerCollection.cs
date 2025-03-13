using TMPro;
using UnityEngine;

public class PlayerCollection : MonoBehaviour
{

    private int score = 0;
    public TMP_Text scoreText;
    
    //add scoring system here
    private void OnTriggerEnter(Collider other)
    {
        //if the object is TAGGED with "COLLECTABLE", then it is destroyed
        if (other.CompareTag("Collectable"))
        {
             Destroy(other.gameObject);
        }
    }

    private void AddScore(int points)
    {
        score = score + points;
        scoreText.text = $"<b>Score</b>: {score}";
    }
}
