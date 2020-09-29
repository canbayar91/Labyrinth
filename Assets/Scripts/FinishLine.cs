using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {

	public GUIText resultText;

	// Use this for initialization
	void Start () {
		resultText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Called when the object is triggered
	void OnTriggerEnter(Collider other) {
		if (other.tag == "boulder") {
			resultText.text = "YOU WON!";
			ResetLevel ();
		}
	}

	public void ResetLevel() {
		Application.LoadLevel (0);
	}

}
