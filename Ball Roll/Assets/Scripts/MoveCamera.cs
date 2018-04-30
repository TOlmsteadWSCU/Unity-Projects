using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;
	// Use this for initialization
	void Start ()
    {
        offset = transform.position - player.transform.position;
	}//Start
	
	// Update is called once per frame
	void LateUpdate ()
    {
        transform.position = player.transform.position + offset;
	}//LateUpdate
}//MoveCamera
