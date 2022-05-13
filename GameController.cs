using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public GameObject ball;
    private bool started = false;
    public Text scoreTextLeft;
    public Text scoreTextRight;
    private int scoreLeft = 0;
    private int scoreRight = 0;
    private Vector3 startingPosition;

    private Ballcontroller ballcontroller;

    void Start() {
        this.ballcontroller = this.ball.GetComponent<Ballcontroller>();
        this.startingPosition = this.ball.transform.position;
    }
    void Update() {
        if (started) {
            return;
        }

        if (Input.GetKey(KeyCode.Space)) {
            this.started = true;
            this.ballcontroller.Go();
        }
    }
    public void ScoreGoalLeft() {
        Debug.Log("ScoreGoalLeft");
        this.scoreRight += 1;
        UpdateUI();
        Debug.Log("Left: " + scoreLeft + " Right:" + scoreRight);
        ResetBall();
    }

    public void ScoreGoalRight() {
        Debug.Log("ScoreGoalRight");
        this.scoreLeft += 1;
        UpdateUI();
        Debug.Log("Left: " + scoreLeft + " Right:" + scoreRight);
        ResetBall();
    }

    private void UpdateUI() {
        this.scoreTextLeft.text = this.scoreLeft.ToString();
        this.scoreTextRight.text = this.scoreRight.ToString();
    }

    private void ResetBall() {
        this.ballcontroller.Stop();
        this.ball.transform.position = this.startingPosition;
        this.ballcontroller.Go();
    }
}
