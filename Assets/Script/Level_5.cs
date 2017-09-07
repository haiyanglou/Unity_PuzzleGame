using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_5 : MonoBehaviour {

	public DisPoint dispoint;
	private bool word1 = false;
	private bool word2 = false;
	private bool word3 = false;
	private bool word4 = false;
	private bool word5 = false;
	private bool word6 = false;

	public float shijianleft;
	public Slider bar;
	public Image fill;
	public Image PauseMenu;
	public Image LostMenu;
	public Image WinMenu;
	public Image Shop;
	public bool operatable = true;

	private int Fenshu;

	public Text Hint;
	public Text Addtimenum;
	public Text Showhintnum;

	private bool yinyue = true;
	public Slider MusicChange;
	public Toggle MusicSwitch;

	// Use this for initialization
	void Start () {
		shijianleft = 90.0f;
		Fenshu = Global.score;
		Time.timeScale = 1;
		Global.itemscore = 0;

	}

	// Update is called once per frame
	void Update () {
		Addtimenum.text = Global.num_addtime + "";
		Showhintnum.text = Global.num_showhint + "";

		if (GameObject.Find ("Score")) {
			GameObject.Find ("Score").GetComponent<Text> ().text = "Score : " + Global.score.ToString();
		}

		if (dispoint.point[0].transform.FindChild("D")
			&& dispoint.point[1].transform.FindChild("R")
			&& dispoint.point[2].transform.FindChild("E")
			&& dispoint.point[3].transform.FindChild("S")
			&& dispoint.point[4].transform.FindChild("S")) {
			word1 = true;
			Global.eachscore [23] = 5;
		}	

		if (dispoint.point[5].transform.FindChild("T")
			&& dispoint.point[7].transform.FindChild("U")
			&& dispoint.point[9].transform.FindChild("X")
			&& dispoint.point[12].transform.FindChild("E")
			&& dispoint.point[16].transform.FindChild("D")
			&& dispoint.point[18].transform.FindChild("O")) {
			word2 = true;
			Global.eachscore [24] = 5;
		}	

		if (dispoint.point[4].transform.FindChild("S")
			&& dispoint.point[6].transform.FindChild("H")
			&& dispoint.point[8].transform.FindChild("I")
			&& dispoint.point[11].transform.FindChild("R")
			&& dispoint.point[15].transform.FindChild("T")) {
			word3 = true;
			Global.eachscore [25] = 5;
		}	

		if (dispoint.point[10].transform.FindChild("S")
			&& dispoint.point[13].transform.FindChild("H")
			&& dispoint.point[17].transform.FindChild("O")
			&& dispoint.point[20].transform.FindChild("E")
			&& dispoint.point[26].transform.FindChild("S")) {
			word4 = true;
			Global.eachscore [26] = 5;
		}	

		if (dispoint.point[13].transform.FindChild("H")
			&& dispoint.point[14].transform.FindChild("A")
			&& dispoint.point[15].transform.FindChild("T")) {
			word5 = true;
			Global.eachscore [27] = 5;
		}	

		if (dispoint.point[18].transform.FindChild("O")
			&& dispoint.point[19].transform.FindChild("V")
			&& dispoint.point[20].transform.FindChild("E")
			&& dispoint.point[21].transform.FindChild("R")
			&& dispoint.point[22].transform.FindChild("A")
			&& dispoint.point[23].transform.FindChild("L")
			&& dispoint.point[24].transform.FindChild("L")
			&& dispoint.point[25].transform.FindChild("S")) {
			word6 = true;
			Global.eachscore [28] = 5;
		}		



		Global.score = Fenshu + Global.eachscore [23] + Global.eachscore [24] + Global.eachscore [25]
			+ Global.eachscore [26] + Global.eachscore [27] + Global.eachscore [28] - Global.itemscore;

		if (word1 && word2 && word3 && word4 && word5 && word6) {
			WinGame ();
			Global.sixthlevel = true;
		}


		shijianleft -= Time.deltaTime;
		if (shijianleft < 0) {
			shijianleft = 0;
			LostGame ();
		}
		bar.value = shijianleft / 90.0f;

		if (shijianleft > 45.0 && shijianleft < 90.0) {
			fill.color = Color.green;
		}
		else if (shijianleft > 15.0 && shijianleft < 45.0) {
			fill.color = Color.yellow;
		}
		else if (shijianleft > 0.0 && shijianleft < 15.0) {
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
		SceneManager.LoadScene ("fifthstage");
		//Application.LoadLevel (2);
	}

	public void Reselect(){
		SceneManager.LoadScene ("ChooseLevel");
		Time.timeScale = 0;
	}

	public void Nextlevel(){
		SceneManager.LoadScene ("sixthstage");
		Time.timeScale = 0;
	}

	public void ReturntoMain(){
		SceneManager.LoadScene ("MainMenu");
		Time.timeScale = 0;
	}

	public void SwitchMusic(){
		if (yinyue) {
			GameObject.Find ("BGM").GetComponent<AudioSource> ().Stop();
			MusicChange.value = 0;
		} else {
			GameObject.Find ("BGM").GetComponent<AudioSource> ().Play ();
			MusicChange.value = 1;
		}
		yinyue = !yinyue;
	}

	public void ChangeMusic(){
		GameObject.Find ("BGM").GetComponent<AudioSource> ().volume = MusicChange.value;
		GameObject.Find ("VolumeValue").GetComponent<Text> ().text = (int)(MusicChange.value * 100) + "%";
	}

	public void DelayTime(){
		if (Global.num_addtime > 0) {
			shijianleft += 30;
			Global.num_addtime -= 1;
		}
	}

	public void ShowHint(){
		if (Global.num_showhint > 0) {
			float ran = Random.Range (0, 6);
			if (ran == 0) {
				Hint.text = "dress";
			}
			else if (ran == 1) {
				Hint.text = "shirt";
			}
			else if (ran == 2) {
				Hint.text = "tuxedo";
			}
			else if (ran == 3) {
				Hint.text = "shoes";
			}
			else if (ran == 4) {
				Hint.text = "hat";
			}
			else if (ran == 5) {
				Hint.text = "overalls";
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
}
