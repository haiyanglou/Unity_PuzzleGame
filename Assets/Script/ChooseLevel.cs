using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseLevel : MonoBehaviour {

	public Button one;
	public Button two;
	public Button three;
	public Button four;
	public Button five;

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
		if (!Global.firstlevel) {
			one.interactable = false;
		}
		if (!Global.secondlevel) {
			two.interactable = false;
		}
		if (!Global.thirdlevel) {
			three.interactable = false;
		}
		if (!Global.fourthlevel) {
			four.interactable = false;
		}
		if (!Global.fifthlevel) {
			five.interactable = false;
		}
	}

	public void BackToMain(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void ToFirst(){
		SceneManager.LoadScene ("firststage");
		Destroy(GameObject.Find("Music(Clone)"));
	}

	public void ToSecond(){
		SceneManager.LoadScene ("secondstage");
		Destroy(GameObject.Find("Music(Clone)"));
	}

	public void ToThird(){
		SceneManager.LoadScene ("thirdstage");
		Destroy(GameObject.Find("Music(Clone)"));
	}

	public void ToFourth(){
		SceneManager.LoadScene ("fourthstage");
		Destroy(GameObject.Find("Music(Clone)"));
	}

	public void ToFifth(){
		SceneManager.LoadScene ("fifthstage");
		Destroy(GameObject.Find("Music(Clone)"));
	}
}
