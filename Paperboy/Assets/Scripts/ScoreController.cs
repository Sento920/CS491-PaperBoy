using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
    // This class should handle all the scoring BIZ
    public float score;
    private float multiplier;
    public float numPapers;
    public Text scoreDisplay;
    private float scoreTemp;


	// Use this for initialization
	void Start () {
        score = 0;
        scoreTemp = 0;
        multiplier = 1;

	}
	
	// Update is called once per frame
	void Update () {
        updateDisplay();
	}


    public void getSpeedMult(int mult)
    {
        if(mult > 0)
        {
            multiplier = mult;
        }
    }

    private void updateDisplay()
    {
        score += (scoreTemp * multiplier);
        scoreTemp = 0;
        scoreDisplay.text = "Score: " + score;
    }

    public void getScoreValue(float points)
    {
        scoreTemp = points;
    }

    public void resetHiScores()
    {
        PlayerPrefs.SetFloat("Level1", 750);
        PlayerPrefs.SetString("Level1Name","Papyrus");
        PlayerPrefs.SetFloat("Level2", 850);
        PlayerPrefs.SetString("Level2Name", "Saitama");
        PlayerPrefs.SetFloat("Level3", 950);
        PlayerPrefs.SetString("Level3Name", "Edward");
    }

    public void setHighScore(string levelID, string name, float score)
    {
        string id;
        if(levelID == "level1")
        {
            id = "level1Name";
        }
        else if (levelID == "level2")
        {
            id = "level2Name";
        }
        else 
        {
            id = "level3Name";
        }

        PlayerPrefs.SetFloat(levelID,score);
        PlayerPrefs.SetString(id, name);
    }
}
