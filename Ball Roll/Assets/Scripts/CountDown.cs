using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {
    public static float timer = 30.0f;
	// Use this for initialization
	void Start () {
	
	}//Start
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        //if(timer == 0.0f)
        //{
        //    if (c.gameObject.CompareTag("Player"))
        //    {
        //        c.gameObject.SetActive(false);
        //    }
        //}
        
	}//Update
    void OnGUI()
    {
        if(timer > 0)
        {
            GUI.Label(new Rect(100, 100, 200, 100), "Time Left: " + timer);
        }//if statement
        else
        {
            
            GUI.Label(new Rect(100, 100, 200, 100), "Game Over");
        }//else statement
    }//OnGUI
}//CountDown
