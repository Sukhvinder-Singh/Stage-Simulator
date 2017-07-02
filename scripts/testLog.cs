using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testLog : MonoBehaviour {


	public void testLogger (string ActionCommand) {
		switch(ActionCommand) {
		case "hello":
			print ("hello");
			break;
		case "bye":
			print ("bye");
			break;
		default:
			print ("What");
			break;
		
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
