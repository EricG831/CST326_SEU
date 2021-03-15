using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;

    public RobotCharacter robot;
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameObject.Find("Robot")){
            StartCoroutine(RIPRobot());
        }

        if(Score == 185){
                    SceneManager.LoadScene (sceneName:"Credits");

        }
    }

    public void refresh(int score)
    {
        Score += score;
        Debug.Log(Score);
        scoreText.text = "SCORE:" + String.Format("{0:0000}", Score);
    }

    
    private IEnumerator RIPRobot(){
        Debug.Log("RIP Robot will wait 3 seconds now");
        yield return new WaitForSeconds (1);
        Debug.Log("OK, next scene");
        SceneManager.LoadScene (sceneName:"Credits");
    }
}
