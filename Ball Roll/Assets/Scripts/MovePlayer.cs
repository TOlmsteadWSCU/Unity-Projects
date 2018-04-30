using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {
    public Rigidbody rb;
    public float speed = 10;
    private int count;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
	}//Start
	void FixedUpdate ()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveH, 0.0f, moveV);
        rb.AddForce(move * speed);
	}//FixedUpdate
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
        } //if statement
        if (other.gameObject.CompareTag("RemovePlayer"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Tree"))
        {
            other.gameObject.SetActive(false);
        }
    }//OnTriggerEnter
    void OnGUI()
    {
        GUI.Label(new Rect(300, 300, 400, 300), "Score: " + count);
        
    }//OnGUI
}//MovePlayer
