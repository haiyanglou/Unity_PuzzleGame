using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System;

public class MainMenu : MonoBehaviour{

	public RectTransform panel1;
	public RectTransform panel2;
	public RectTransform panel3;

	public Slider MusicChange;
	public Toggle MusicSwitch;
	public Text info;

	private bool yinyue = true;
	private bool yinxiao = true;

	public GameObject Bgm;
	GameObject bgm;

	Button start;
	Button option;
	Button help;
	Button reset;
	Button multi;
	Button exit;

	// Use this for initialization
	void Start () {

		start = GameObject.Find("Start").GetComponent<Button>();
		EventTriggerListener.Get(start.gameObject).onEnter = OnButtonEnter;
		EventTriggerListener.Get(start.gameObject).onExit = OnButtonExit;

		option = GameObject.Find("Option").GetComponent<Button>();
		EventTriggerListener.Get(option.gameObject).onEnter = OnButtonEnter;
		EventTriggerListener.Get(option.gameObject).onExit = OnButtonExit;

		help = GameObject.Find("Help").GetComponent<Button>();
		EventTriggerListener.Get(help.gameObject).onEnter = OnButtonEnter;
		EventTriggerListener.Get(help.gameObject).onExit = OnButtonExit;

		reset = GameObject.Find("Reset").GetComponent<Button>();
		EventTriggerListener.Get(reset.gameObject).onEnter = OnButtonEnter;
		EventTriggerListener.Get(reset.gameObject).onExit = OnButtonExit;

		multi = GameObject.Find("Multi").GetComponent<Button>();
		EventTriggerListener.Get(multi.gameObject).onEnter = OnButtonEnter;
		EventTriggerListener.Get(multi.gameObject).onExit = OnButtonExit;

		exit = GameObject.Find("Exit").GetComponent<Button>();
		EventTriggerListener.Get(exit.gameObject).onEnter = OnButtonEnter;
		EventTriggerListener.Get(exit.gameObject).onExit = OnButtonExit;

		bgm = GameObject.FindGameObjectWithTag ("bgm");
		if (bgm == null) {
			bgm = (GameObject)Instantiate (Bgm);
		}
	}

	private void OnButtonEnter(GameObject go){
		if(go == GameObject.Find("Start")){
			info.text = "Start the game. You can choose the level up to the most recent unlocked level";
		}
		else if (go == GameObject.Find ("Option")) {
			info.text = "Swich the music";
		} 
		else if (go == GameObject.Find ("Help")) {
			info.text = "View the way to play this game with words and pitures";
		} 
		else if (go == GameObject.Find ("Reset")) {
			info.text = "Lock all the level except the first level";
		} 
		else if (go == GameObject.Find ("Multi")) {
			info.text = "Open a server or a client to begin the multi-mode";
		} 
		else if (go == GameObject.Find ("Exit")) {
			info.text = "Do you want to quit?";
		} 
		else {
			info.text = "";
		}
	}

	private void OnButtonExit(GameObject go){
//		if(go == GameObject.Find("Start")){
//			info.text = "Start the game. You can choose the level up to the most recent unlocked level";
//		}
//		else if (go == GameObject.Find ("Option")) {
//			info.text = "Swich the music";
//		} 
		//else {
			info.text = "";
		//}
	}
	
	// Update is called once per frame
	void Update () {
//		if (!EventSystem.current.IsPointerOverGameObject ()) {
//			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
//			RaycastHit hitInfo;
//
//			if(Physics.Raycast(ray,out hitInfo)){
//				if (hitInfo.collider.name == "Start ") {
//					information.text = "f@";
//				}
//			}
//		}
	}


	public void Startgame(){
		GameObject.Find ("Start").GetComponent<AudioSource> ().Play ();
		SceneManager.LoadScene ("ChooseLevel");
		DontDestroyOnLoad (GameObject.Find ("Music(Clone)").GetComponent<AudioSource> ());
	}

	public void Option(){
		GameObject.Find ("Option").GetComponent<AudioSource> ().Play ();
		panel1.anchoredPosition = new Vector2 (-1000, 0);
		panel2.anchoredPosition = new Vector2 (0, 0);
		panel3.anchoredPosition = new Vector2 (1000, 0);
	}

	public void Help(){
		GameObject.Find ("Help").GetComponent<AudioSource> ().Play ();
		panel1.anchoredPosition = new Vector2 (-1000, 0);
		panel2.anchoredPosition = new Vector2 (1000, 0);
		panel3.anchoredPosition = new Vector2 (0, 0);
	}

	public void Reset(){
		GameObject.Find ("Reset").GetComponent<AudioSource> ().Play ();
		Global.firstlevel = true;
		Global.secondlevel = false;
		Global.thirdlevel = false;

		for (int i = 0; i < Global.eachscore.Length; i++) {
			Global.eachscore [i] = 0;
			Global.itemscore = 0;
		}
	}

	public void MultiLevel(){
		GameObject.Find ("Multi").GetComponent<AudioSource> ().Play ();
		SceneManager.LoadScene ("ChooseMulti");
		DontDestroyOnLoad (GameObject.Find ("Music(Clone)").GetComponent<AudioSource> ());
	}

	public void Exit(){
		GameObject.Find ("Exit").GetComponent<AudioSource> ().Play ();
		Application.Quit ();
	}

	public void Back(){
		GameObject.Find ("Back").GetComponent<AudioSource> ().Play ();
		panel1.anchoredPosition = new Vector2 (0, 0);
		panel2.anchoredPosition = new Vector2 (-1000, 0);
		panel3.anchoredPosition = new Vector2 (1000, 0);
	}

	public void SwitchMusic(){
		if (yinyue) {
			GameObject.Find ("Music(Clone)").GetComponent<AudioSource> ().Stop();
			MusicChange.value = 0;
		} else {
			GameObject.Find ("Music(Clone)").GetComponent<AudioSource> ().Play ();
			MusicChange.value = 1;
		}
		yinyue = !yinyue;
	}

	public void SwitchSound(){
		if (yinxiao) {
			GameObject.Find ("Option").GetComponent<AudioSource> ().enabled = false;
		} else {
			GameObject.Find ("Option").GetComponent<AudioSource> ().enabled = true;
		}
		yinxiao = !yinxiao;
	}

	public void ChangeMusic(){
		GameObject.Find ("Music(Clone)").GetComponent<AudioSource> ().volume = MusicChange.value;
		GameObject.Find ("VolumeValue").GetComponent<Text> ().text = (int)(MusicChange.value * 100) + "%";
	}
}
