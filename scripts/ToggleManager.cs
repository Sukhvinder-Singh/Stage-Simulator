using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class ToggleManager : MonoBehaviour { 

	public GameObject thisCanvas;

	bool active=true;
	public void SetON() {
		thisCanvas.SetActive (true);
		active = true;
	}

	public void SetOff() {
		thisCanvas.SetActive (false);
		active = false;
	}

	public void AlternateSet() {
		if (active)
			SetOff();
		else if (active == false)
			SetON ();
		
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
