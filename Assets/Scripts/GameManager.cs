using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool started;

    public GameObject startStuff;
    public GameObject scrollingText;

    public GameObject rightSpawn;
    public GameObject leftSpawn;
    public GameObject rightTIEspawn;
    public GameObject leftTIEspawn;
    public GameObject scoreCanvas;

    public float score;

    public bool scoring;

    public TMP_Text scoreText;

    public GameObject winningText;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {

        if (started)
        {
            if (startStuff.activeSelf)
            {
                startStuff.SetActive(false);
            }

            if (scrollingText!=null &&!scrollingText.activeSelf)
            {
                scrollingText.SetActive(true);
            }
        }

        if (score >= 15)
        {
            rightSpawn.SetActive(false);
            leftSpawn.SetActive(false);
            rightTIEspawn.SetActive(false);
            leftTIEspawn.SetActive(false);
            scoring = false;
            score = 0;
            scoreText.enabled = false;
            winningText.SetActive(true);
        }

        if (scoring)
        {
            scoreText.text = score.ToString() + "/15";
        }
    }

    public void EnableSpawns()
    {
        rightSpawn.SetActive(true);
        leftSpawn.SetActive(true);
        rightTIEspawn.SetActive(true);
        leftTIEspawn.SetActive(true);
        scoreCanvas.SetActive(true);
        scoring = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
