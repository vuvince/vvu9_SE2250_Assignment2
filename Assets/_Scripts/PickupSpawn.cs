using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawn : MonoBehaviour {

	int numObjects = 8;
	public GameObject prefab;
	private GameObject Pickup = new GameObject();

	void Start() {
		Vector3 center = transform.position;
		Quaternion angle = new Quaternion(45, 45, 45, 0);

		for (int i = 0; i < (numObjects/3); i++) {
			int a = i * 180;
			Vector3 pos = Circle (center, 5.0f, a);
			Pickup = Instantiate (prefab, pos, angle);
			Pickup.GetComponent<Renderer> ().material.color = Color.red;
			Pickup.tag= "Red";
		}

		for (int i = 0; i < (numObjects/3); i++) {
			int a = i * 180 + 45;
			Vector3 pos = Circle(center, 5.0f ,a);
			Pickup = Instantiate(prefab, pos, angle);
			Pickup.GetComponent<Renderer> ().material.color = Color.gray;
			Pickup.tag = "Gray";
		}

		for (int i = 0; i < (numObjects/3); i++) {
			int a = i * 180 + 90;
			Vector3 pos = Circle(center, 5.0f ,a);
			Pickup = Instantiate(prefab, pos, angle);
			Pickup.GetComponent<Renderer> ().material.color = Color.green;
			Pickup.tag = "Green";
		}

		for (int i = 0; i < (numObjects/3); i++) {
			int a = i * 180 + 135;
			Vector3 pos = Circle(center, 5.0f ,a);
			Pickup = Instantiate(prefab, pos, angle);
			Pickup.GetComponent<Renderer> ().material.color = Color.blue;
			Pickup.tag = "Blue";
		}
	}

	Vector3 Circle(Vector3 center, float radius,int a) {
		Debug.Log(a);
		float ang = a;
		Vector3 pos;
		pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
		pos.z = center.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
		pos.y = center.y;
		return pos;
	}

}
