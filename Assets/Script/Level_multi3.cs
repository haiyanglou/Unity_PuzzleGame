using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_multi3 : MonoBehaviour
{

	public Image WinMenu;

	private bool yinyue = true;
	public Slider MusicChange;
	public Toggle MusicSwitch;

	private int[] number = new int[100];
	private string[] Name = new string[100];

	// Use this for initialization
	void Start()
	{
		for (int i = 0; i < 100; i++) {
			number [i] = i - 1;
			Name[i] = "Player " + number [i].ToString ();
		}

	}

	// Update is called once per frame
	void Update()
	{
		for (int i = 0; i < 100; i++) {
			if (GameObject.Find (Name [i])) {
				if ((Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block").transform.position, GameObject.Find(Name[i]).transform.FindChild("W1").transform.position) < 0.25
					|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block").transform.position, GameObject.Find(Name[i]).transform.FindChild("W2").transform.position) < 0.25
					|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block").transform.position, GameObject.Find(Name[i]).transform.FindChild("W3").transform.position) < 0.25
					|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block").transform.position, GameObject.Find(Name[i]).transform.FindChild("W4").transform.position) < 0.25
					|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block").transform.position, GameObject.Find(Name[i]).transform.FindChild("W5").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (1)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (1)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (1)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H3").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (1)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H4").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (1)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H5").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (1)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H6").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (1)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H7").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (1)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H8").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (1)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H9").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (2)").transform.position, GameObject.Find(Name[i]).transform.FindChild("A1").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (3)").transform.position, GameObject.Find(Name[i]).transform.FindChild("T1").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (4)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (4)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (4)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H3").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (4)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H4").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (4)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H5").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (4)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H6").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (4)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H7").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (4)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H8").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (4)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H9").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (5)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (5)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (5)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H3").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (5)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H4").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (5)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H5").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (5)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H6").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (5)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H7").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (5)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H8").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (5)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H9").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (6)").transform.position, GameObject.Find(Name[i]).transform.FindChild("O1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (6)").transform.position, GameObject.Find(Name[i]).transform.FindChild("O2").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (7)").transform.position, GameObject.Find(Name[i]).transform.FindChild("W1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (7)").transform.position, GameObject.Find(Name[i]).transform.FindChild("W2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (7)").transform.position, GameObject.Find(Name[i]).transform.FindChild("W3").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (7)").transform.position, GameObject.Find(Name[i]).transform.FindChild("W4").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (7)").transform.position, GameObject.Find(Name[i]).transform.FindChild("W5").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (8)").transform.position, GameObject.Find(Name[i]).transform.FindChild("W1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (8)").transform.position, GameObject.Find(Name[i]).transform.FindChild("W2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (8)").transform.position, GameObject.Find(Name[i]).transform.FindChild("W3").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (8)").transform.position, GameObject.Find(Name[i]).transform.FindChild("W4").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (8)").transform.position, GameObject.Find(Name[i]).transform.FindChild("W5").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (9)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (9)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (9)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H3").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (9)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H4").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (9)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H5").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (9)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H6").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (9)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H7").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (9)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H8").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (9)").transform.position, GameObject.Find(Name[i]).transform.FindChild("H9").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (10)").transform.position, GameObject.Find(Name[i]).transform.FindChild("Y1").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (11)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (11)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (11)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H3").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (11)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H4").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (11)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H5").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (11)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H6").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (11)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H7").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (11)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H8").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (11)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H9").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (12)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (12)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (12)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H3").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (12)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H4").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (12)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H5").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (12)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H6").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (12)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H7").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (12)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H8").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (12)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H9").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (13)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("W1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (13)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("W2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (13)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("W3").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (13)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("W4").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (13)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("W5").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (14)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (14)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (14)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H3").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (14)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H4").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (14)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H5").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (14)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H6").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (14)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H7").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (14)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H8").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (14)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H9").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (15)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("O1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (15)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("O2").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (16)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("S1").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (17)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("E1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (17)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("E2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (17)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("E3").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (18)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (18)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (18)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H3").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (18)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H4").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (18)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H5").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (18)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H6").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (18)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H7").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (18)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H8").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (18)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H9").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (19)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("M1").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (20)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("R1").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (21)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("I1").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (22)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("E1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (22)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("E2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (22)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("E3").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (23)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("C1").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (24)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("W1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (24)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("W2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (24)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("W3").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (24)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("W4").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (24)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("W5").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (25)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (25)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (25)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H3").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (25)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H4").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (25)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H5").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (25)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H6").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (25)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H7").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (25)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H8").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (25)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("H9").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (26)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("E1").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (26)").transform.position, GameObject.Find(Name[i]).transform.FindChild ("E2").transform.position) < 0.25
						|| Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (26)").transform.position, GameObject.Find(Name[i]).transform.FindChild("E3").transform.position) < 0.25)
					&&
					(Vector3.Distance (GameObject.Find (Name[i]).transform.FindChild ("Block (27)").transform.position, GameObject.Find(Name[i]).transform.FindChild("N1").transform.position) < 0.25)) {
					WinGame();
					GameObject.Find("Winner").GetComponent<Text>().text = "Win!";
				}
			}
		}


		

	}





	public void WinGame()
	{
		WinMenu.GetComponent<CanvasGroup>().alpha = 1;
		WinMenu.GetComponent<CanvasGroup>().interactable = true;
		WinMenu.transform.position = new Vector3(459, 202, 0);
		Global.fourthlevel_m = true;
	}

	public void Restart()
	{
		SceneManager.LoadScene("MultiLevel3");
	}

	public void Reselect()
	{
		SceneManager.LoadScene("ChooseMulti");

	}

	public void NextLevel()
	{
		SceneManager.LoadScene("MultiLevel4");

	}

	public void ReturntoMain()
	{
		SceneManager.LoadScene("MainMenu");
	}

	public void SwitchMusic()
	{
		if (yinyue)
		{
			GameObject.Find("Music").GetComponent<AudioSource>().Stop();
			MusicChange.value = 0;
		}
		else
		{
			GameObject.Find("Music").GetComponent<AudioSource>().Play();
			MusicChange.value = 1;
		}
		yinyue = !yinyue;
	}

	public void ChangeMusic()
	{
		GameObject.Find("Music").GetComponent<AudioSource>().volume = MusicChange.value;
		GameObject.Find("VolumeValue").GetComponent<Text>().text = (int)(MusicChange.value * 100) + "%";
	}
}
