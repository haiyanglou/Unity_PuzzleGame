using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class ShangSe : NetworkBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public override void OnStartLocalPlayer(){
		foreach (Transform child in transform) {
			child.GetComponent<MeshRenderer> ().material.color = Color.blue;
		}
	}
}
