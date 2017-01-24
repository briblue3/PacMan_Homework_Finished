using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostGenerator : MonoBehaviour {
	public Rigidbody ghost;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 4; i++) {
			Rigidbody ghostClone = (Rigidbody)Instantiate (ghost);
		}
	} 
}
