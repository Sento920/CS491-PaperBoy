using UnityEngine;
using System.Collections;

public class ScoreEnd : MonoBehaviour {

    public float scoreValue;
    private ScoreController sc;

    void Start()
    {
        sc = GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Paper")
        {
            sc.getScoreValue(scoreValue);
        }
    }

}
