using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_multi2 : MonoBehaviour
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
				if ((Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("1").transform.position, GameObject.Find(Name[i]).transform.FindChild("S1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("1").transform.position, GameObject.Find(Name[i]).transform.FindChild("S2").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("2").transform.position, GameObject.Find(Name[i]).transform.FindChild("R1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("2").transform.position, GameObject.Find(Name[i]).transform.FindChild("R2").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("3").transform.position, GameObject.Find(Name[i]).transform.FindChild("I1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("3").transform.position, GameObject.Find(Name[i]).transform.FindChild("I2").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("3").transform.position, GameObject.Find(Name[i]).transform.FindChild("I3").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("3").transform.position, GameObject.Find(Name[i]).transform.FindChild("I4").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("4").transform.position, GameObject.Find(Name[i]).transform.FindChild("S1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("4").transform.position, GameObject.Find(Name[i]).transform.FindChild("S2").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("5").transform.position, GameObject.Find(Name[i]).transform.FindChild("E1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("5").transform.position, GameObject.Find(Name[i]).transform.FindChild("E2").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("6").transform.position, GameObject.Find(Name[i]).transform.FindChild("E1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("6").transform.position, GameObject.Find(Name[i]).transform.FindChild("E2").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("7").transform.position, GameObject.Find(Name[i]).transform.FindChild("I1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("7").transform.position, GameObject.Find(Name[i]).transform.FindChild("I2").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("7").transform.position, GameObject.Find(Name[i]).transform.FindChild("I3").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("7").transform.position, GameObject.Find(Name[i]).transform.FindChild("I4").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("8").transform.position, GameObject.Find(Name[i]).transform.FindChild("N1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("8").transform.position, GameObject.Find(Name[i]).transform.FindChild("N2").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("9").transform.position, GameObject.Find(Name[i]).transform.FindChild("G1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("9").transform.position, GameObject.Find(Name[i]).transform.FindChild("G2").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("10").transform.position, GameObject.Find(Name[i]).transform.FindChild("N1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("10").transform.position, GameObject.Find(Name[i]).transform.FindChild("N2").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("11").transform.position, GameObject.Find(Name[i]).transform.FindChild("H1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("11").transform.position, GameObject.Find(Name[i]).transform.FindChild("H2").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("12").transform.position, GameObject.Find(Name[i]).transform.FindChild("I1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("12").transform.position, GameObject.Find(Name[i]).transform.FindChild("I2").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("12").transform.position, GameObject.Find(Name[i]).transform.FindChild("I3").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("12").transform.position, GameObject.Find(Name[i]).transform.FindChild("I4").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("13").transform.position, GameObject.Find(Name[i]).transform.FindChild("T1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("13").transform.position, GameObject.Find(Name[i]).transform.FindChild("T2").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("14").transform.position, GameObject.Find(Name[i]).transform.FindChild("R1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("14").transform.position, GameObject.Find(Name[i]).transform.FindChild("R2").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("15").transform.position, GameObject.Find(Name[i]).transform.FindChild("I1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("15").transform.position, GameObject.Find(Name[i]).transform.FindChild("I2").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("15").transform.position, GameObject.Find(Name[i]).transform.FindChild("I3").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("15").transform.position, GameObject.Find(Name[i]).transform.FindChild("I4").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("16").transform.position, GameObject.Find(Name[i]).transform.FindChild("G1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("16").transform.position, GameObject.Find(Name[i]).transform.FindChild("G2").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("17").transform.position, GameObject.Find(Name[i]).transform.FindChild("H1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("17").transform.position, GameObject.Find(Name[i]).transform.FindChild("H2").transform.position) < 0.25)
					&& (Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("18").transform.position, GameObject.Find(Name[i]).transform.FindChild("T1").transform.position) < 0.25 || Vector3.Distance(GameObject.Find(Name[i]).transform.FindChild("18").transform.position, GameObject.Find(Name[i]).transform.FindChild("T2").transform.position) < 0.25)
				)
				{
					WinGame();
					GameObject.Find("Winner").GetComponent<Text>().text = "Win!";
				}
				Debug.Log("nimabi");
			}
		}


     
    }


    public void WinGame()
    {
        WinMenu.GetComponent<CanvasGroup>().alpha = 1;
        WinMenu.GetComponent<CanvasGroup>().interactable = true;
        WinMenu.transform.position = new Vector3(459, 202, 0);
		Global.thirdlevel_m = true;
    }

	public void Restart()
	{
		SceneManager.LoadScene("MultiLevel2");
	}

	public void Reselect()
	{
		SceneManager.LoadScene("ChooseMulti");

	}

	public void NextLevel()
	{
		SceneManager.LoadScene("MultiLevel3");

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
