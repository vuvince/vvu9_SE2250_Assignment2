using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countTxt;
	public Text scoreTxt;
	public Text win;
	private int count;
	private Rigidbody rb;


	// Use this for initialization
	void Start () {
		count = 0;
		rb = GetComponent<Rigidbody> ();
		countTxt.text = "Score: " + count.ToString();
		scoreTxt.text = " ";
		win.text = " ";
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
		if (count == 20) {
			win.text = "Win!";
		}
	}

	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.CompareTag("Red")) {
			other.gameObject.SetActive(false);
			count += 4;
			scoreTxt.text = "+4";
		}

		if (other.gameObject.CompareTag("Green")) {
			other.gameObject.SetActive(false);
			count += 3;
			scoreTxt.text = "+3";
		}

		if (other.gameObject.CompareTag("Blue")) {
			other.gameObject.SetActive(false);
			count += 2;
			scoreTxt.text = "+2";
		}

		if (other.gameObject.CompareTag("Gray")) {
			other.gameObject.SetActive(false);
			++count;
			scoreTxt.text = "+1";
		}

		countTxt.text = "Score: " + count.ToString();
	}
}
