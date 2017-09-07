using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_1 : MonoBehaviour {

	public float shijianleft;
	public Slider bar;
	public Image fill;
	public Image PauseMenu;
	public Image LostMenu;
	public Image WinMenu;
	public Image Shop;
	public bool operatable = true;

	public DisPoint dispoint;
	private bool word1 = false;
	private bool word2 = false;

	private int Fenshu;

	public Text Hint;
	public Text Addtimenum;
	public Text Showhintnum;

	private bool yinyue = true;
	public Slider MusicChange;
	public Toggle MusicSwitch;


	// Use this for initialization
	void Start () {
		Fenshu = Global.score;
		shijianleft = 10.0f;
		Time.timeScale = 1;
		Global.itemscore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (Global.num_addtime);
		Addtimenum.text = Global.num_addtime + "";
		Showhintnum.text = Global.num_showhint + "";

		if (GameObject.Find ("Score")) {
			GameObject.Find ("Score").GetComponent<Text> ().text = "Score : " + Global.score;
		}

		if (dispoint.point[3].transform.FindChild("A")
			&& dispoint.point[4].transform.FindChild("T")) {
			word1 = true;
			Global.eachscore [0] = 5;
		}	

		if (dispoint.point[4].transform.FindChild("T")
			&& dispoint.point[5].transform.FindChild("O")) {
			word2 = true;
			Global.eachscore [1] = 5;
		}	
		Global.score = Fenshu + Global.eachscore [1] + Global.eachscore [0] - Global.itemscore;

		if (word1 && word2) {
			Global.secondlevel = true;
			WinGame ();
		}

		shijianleft -= Time.deltaTime;
		if (shijianleft < 0) {
			shijianleft = 0;
			LostGame ();
		}
		bar.value = shijianleft / 10.0f;

		if (shijianleft > 5.0 && shijianleft < 10.0) {
			fill.color = Color.green;
		}
		else if (shijianleft > 2.0 && shijianleft < 5.0) {
			fill.color = Color.yellow;
		}
		else if (shijianleft > 0.0 && shijianleft < 2.0) {
			fill.color = Color.red;
		}
	}

	public void PauseGame(){
		operatable = false;	
		Time.timeScale = 0;
		PauseMenu.GetComponent<CanvasGroup> ().alpha = 1;
		PauseMenu.GetComponent<CanvasGroup> ().interactable = true;
		PauseMenu.transform.position = new Vector3 (600, 350, 0);
		LostMenu.transform.position = new Vector3 (8000, 0, 0);
		WinMenu.transform.position = new Vector3 (8000, 0, 0);

	}

	public void ContinueGame(){
		operatable = true;	
		Time.timeScale = 1;
		PauseMenu.GetComponent<CanvasGroup> ().alpha = 0;
		PauseMenu.GetComponent<CanvasGroup> ().interactable = false;
	}

	public void LostGame(){
		operatable = false;	
		Time.timeScale = 0;
		LostMenu.GetComponent<CanvasGroup> ().alpha = 1;
		LostMenu.GetComponent<CanvasGroup> ().interactable = true;
		PauseMenu.transform.position = new Vector3 (8000, 0, 0);
		LostMenu.transform.position = new Vector3 (600, 350, 0);
		WinMenu.transform.position = new Vector3 (8000, 0, 0);
	}

	public void WinGame(){
		operatable = false;	
		Time.timeScale = 0;
		WinMenu.GetComponent<CanvasGroup> ().alpha = 1;
		WinMenu.GetComponent<CanvasGroup> ().interactable = true;
		PauseMenu.transform.position = new Vector3 (8000, 0, 0);
		LostMenu.transform.position = new Vector3 (8000, 0, 0);
		WinMenu.transform.position = new Vector3 (600, 350, 0);
	}

	public void Restart(){
		SceneManager.LoadScene ("firststage");
	}

	public void Reselect(){
		SceneManager.LoadScene ("ChooseLevel");
	}

	public void Nextlevel(){
		SceneManager.LoadScene ("secondstage");
	}

	public void ReturntoMain(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void DelayTime(){
		if (Global.num_addtime > 0) {
			shijianleft += 5;
			Global.num_addtime -= 1;
		}
	}

	public void ShowHint(){
		if (Global.num_showhint > 0) {
			float ran = Random.Range (0, 2);
			if (ran == 0) {
				Hint.text = "AT";
			} else if (ran == 1) {
				Hint.text = "OF";
			}
			Global.num_showhint -= 1;
		}
	}

	public void ShowShop(){
		Shop.GetComponent<CanvasGroup> ().alpha = 1;
		Shop.GetComponent<CanvasGroup> ().interactable = true;
	}

	public void CloseShop(){
		Shop.GetComponent<CanvasGroup> ().alpha = 0;
		Shop.GetComponent<CanvasGroup> ().interactable = false;
	}

	public void BuyTime(){
		if (Global.score >= 10) {
			Global.num_addtime += 1;
			Global.itemscore += 10;
		}
	}

	public void BuyWord(){
		if (Global.score >= 50) {
			Global.num_showhint += 1;
			Global.itemscore += 50;
		}
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
