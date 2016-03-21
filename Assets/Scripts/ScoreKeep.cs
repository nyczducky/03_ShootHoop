using UnityEngine;
using System.Collections;

public class ScoreKeep : MonoBehaviour {

    int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        score++;
        print("You scored. Your current score is " + score);
    }
}
