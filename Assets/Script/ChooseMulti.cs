using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System;

public class ChooseMulti : MonoBehaviour {

	public Button one;
	public Button two;
	public Button three;

	public GameObject Bgm;
	GameObject bgm;

	// Use this for initialization
	void Start () {
		bgm = GameObject.FindGameObjectWithTag ("bgm");
		if (bgm == null) {
			bgm = (GameObject)Instantiate (Bgm);
		}
	}

	// Update is called once per frame
	void Update () {
		if (!Global.firstlevel_m) {
			one.interactable = false;
		}
		if (!Global.secondlevel_m) {
			two.interactable = false;
		}
		if (!Global.thirdlevel_m) {
			three.interactable = false;
		}
	}

	public void BackToMain(){
		SceneManager.LoadScene (0);
	}

	public void ToFirst(){
		SceneManager.LoadScene ("MultiLevel");
		Destroy(GameObject.Find("Music(Clone)"));
	}

	public void ToSecond(){
		SceneManager.LoadScene ("MultiLevel2");
		Destroy(GameObject.Find("Music(Clone)"));
	}

	public void ToThird(){
		SceneManager.LoadScene ("MultiLevel3");
		Destroy(GameObject.Find("Music(Clone)"));
	}
}
