using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostControl : MonoBehaviour {
	public float speed;
	public Rigidbody ghost;
	public int d;

	void Start() {
		d = Random.Range (1, 5);

		ghost = GetComponent<Rigidbody> ();
		if (d == 1) {
			ghost.transform.Translate (Mathf.Clamp((speed * Time.deltaTime),-9.5f, 9.5f), 0.0f, 0.0f);
		} else if (d == 2) {
			ghost.transform.Translate (-Mathf.Clamp((speed * Time.deltaTime),-9.5f, 9.5f), 0.0f, 0.0f);
		} else if (d == 3) {
			ghost.transform.Translate (0.0f, 0.0f, Mathf.Clamp((speed * Time.deltaTime),-9.5f, 9.5f));
		} else if (d == 4) {
			ghost.transform.Translate (0.0f, 0.0f, -Mathf.Clamp((speed * Time.deltaTime),-9.5f, 9.5f));
		}
	}

	void Update() {
		if (d == 1) {
			ghost.transform.Translate (Mathf.Clamp((speed * Time.deltaTime),-9.5f, 9.5f), 0.0f, 0.0f);
		} else if (d == 2) {
			ghost.transform.Translate (-Mathf.Clamp((speed * Time.deltaTime),-9.5f, 9.5f), 0.0f, 0.0f);
		} else if (d == 3) {
			ghost.transform.Translate (0.0f, 0.0f, Mathf.Clamp((speed * Time.deltaTime),-9.5f, 9.5f));
		} else if (d == 4) {
			ghost.transform.Translate (0.0f, 0.0f, -Mathf.Clamp((speed * Time.deltaTime),-9.5f, 9.5f));
		}
	}
		

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Walls")) {
			int x = Random.Range (1, 5);
			while (x == d) {
				x = Random.Range (1, 5);
			}
			d = x;
			if (d == 1) {
				ghost.transform.Translate (Mathf.Clamp((speed * Time.deltaTime),-9.5f, 9.5f), 0.0f, 0.0f);
			} else if (d == 2) {
				ghost.transform.Translate (-Mathf.Clamp((speed * Time.deltaTime),-9.5f, 9.5f), 0.0f, 0.0f);
			} else if (d == 3) {
				ghost.transform.Translate (0.0f, 0.0f, Mathf.Clamp((speed * Time.deltaTime),-9.5f, 9.5f));
			} else if (d == 4) {
				ghost.transform.Translate (0.0f, 0.0f, -Mathf.Clamp((speed * Time.deltaTime),-9.5f, 9.5f));
			}
		}
	}
		
}