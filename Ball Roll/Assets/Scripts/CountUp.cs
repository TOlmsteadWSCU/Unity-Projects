using UnityEngine;
using System.Collections;

public class CountUp : MonoBehaviour {
    private float timer = 0.0f;
	// Use this for initialization
	void Start () {
	
	}//Start
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
	}//Update
    void OnGUI()
    {
        if(timer < 30.0f)
        {
            GUI.Label(new Rect(200, 200, 300, 200), "Time: " + timer);
        }//if statement
        else
        {
            GUI.Label(new Rect(200, 200, 300, 200), "Countdown Ended!!!");
        }//else statement
        
    }//OnGUI
}//CountUp
