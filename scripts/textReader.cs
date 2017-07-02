using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI; 
public class textReader : MonoBehaviour {
	string text;
	string[] res;
	public Text thisCanvas;
	public float freq; 
	float timeset; 
	int i = 0;
	// Use this for initialization
	void Start () {
		text = System.IO.File.ReadAllText ("text/text.txt");
		res = text.Split (" " [0]);
		print (text);
		print (res [2]);
		timeset = freq; 
		
	}

	void PromptText() {
		
			freq -= Time.deltaTime;
			if(freq<=0) {
				print (res [i]);
				thisCanvas.text = res [i];
				freq = timeset;
			i++;
			if (i == res.Length)
				i = 0;
			}
		
	}

	// Update is called once per frame
	void Update () {
		
		PromptText ();
	}
}
