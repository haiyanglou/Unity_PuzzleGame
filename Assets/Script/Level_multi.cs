using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_multi : MonoBehaviour {

	public Image WinMenu;

	private bool yinyue = true;
	public Slider MusicChange;
	public Toggle MusicSwitch;

	private int[] number = new int[100];
	private string[] Name = new string[100];

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 100; i++) {
			number [i] = i - 1;
			Name[i] = "Player " + number [i].ToString ();
		}
	}

	// Update is called once per frame
	void Update () {

		for (int i = 0; i < 100; i++) {
			if (GameObject.Find (Name [i])) {
				if (Vector3.Distance (GameObject.Find (Name [i]).transform.FindChild ("L1").transform.position, GameObject.Find (Name [i]).transform.FindChild ("A").transform.position) < 0.25
				   && Vector3.Distance (GameObject.Find (Name [i]).transform.FindChild ("L2").transform.position, GameObject.Find (Name [i]).transform.FindChild ("T").transform.position) < 0.25
				   && Vector3.Distance (GameObject.Find (Name [i]).transform.FindChild ("L3").transform.position, GameObject.Find (Name [i]).transform.FindChild ("O").transform.position) < 0.25) {
					WinGame ();
					GameObject.Find ("Winner").GetComponent<Text> ().text = "Win!";
				}
			}

		}


	}		


	public void WinGame(){
		WinMenu.GetComponent<CanvasGroup> ().alpha = 1;
		WinMenu.GetComponent<CanvasGroup> ().interactable = true;
		WinMenu.transform.position = new Vector3 (459, 202, 0);
		Global.secondlevel_m = true;
	}

	public void Restart()
	{
		SceneManager.LoadScene("MultiLevel");
	}

	public void Reselect()
	{
		SceneManager.LoadScene("ChooseMulti");
	}

	public void NextLevel()
	{
		SceneManager.LoadScene("MultiLevel2");
	}

	public void ReturntoMain()
	{
		SceneManager.LoadScene("MainMenu");
	}


	public void SwitchMusic(){
		if (yinyue) {
			GameObject.Find ("Music").GetComponent<AudioSource> ().Stop();
			MusicChange.value = 0;
		} else {
			GameObject.Find ("Music").GetComponent<AudioSource> ().Play ();
			MusicChange.value = 1;
		}
		yinyue = !yinyue;
	}

	public void ChangeMusic(){
		GameObject.Find ("Music").GetComponent<AudioSource> ().volume = MusicChange.value;
		GameObject.Find ("VolumeValue").GetComponent<Text> ().text = (int)(MusicChange.value * 100) + "%";
	}
}
