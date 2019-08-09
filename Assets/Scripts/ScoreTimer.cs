using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTimer : MonoBehaviour{

    public Text scoreTimeText;
    private float startTime;
    int targetSeconds = 60;


    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        string seconds = (t % 60).ToString("f0");

        string target = targetSeconds.ToString();
        scoreTimeText.text = seconds;

        if (seconds == target)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
