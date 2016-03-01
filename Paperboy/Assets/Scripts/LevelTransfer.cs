using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelTransfer : MonoBehaviour {

    public string ToLevel;


    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(ToLevel);
    }

    public void Transfer()
    {
        SceneManager.LoadScene("tutorial Level");
    }
}
