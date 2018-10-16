using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NumberIncrease : MonoBehaviour {
	public int numberOfClicks;
	public int numberPerClick = 1;
	public UnityEngine.UI.Text numberDisplay;
	public GUIText counterText;

	// Use this for initialization

	void Start () {
		numberOfClicks = numberPerClick;
		counterIncrease ();
		print (numberOfClicks);


	}

	void counterIncrease () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			numberOfClicks += numberPerClick;
			counterText.text = "Clicks: " + numberOfClicks;
		}
		
	}
}
