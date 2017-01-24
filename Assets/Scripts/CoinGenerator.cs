using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour {
	public Rigidbody coin;
	public static int numCoins;

	// Use this for initialization
	void Start () {
		numCoins = Random.Range (10, 50);
		for (int i = 0; i <= numCoins; i++) {
			Vector3 pos = new Vector3 (Random.Range (-9.0f, 9.0f), 0.5f, Random.Range (-9.0f, 9.0f));
			Rigidbody coinClone = (Rigidbody)Instantiate (coin, pos, transform.rotation);
		}
	} 

}