using UnityEngine;
using System.Collections;

public class Global {

	public static int score = 0;
	public static int[] eachscore = new int[100];
	public static int itemscore = 0;

	public static int num_addtime = 1;
	public static int num_showhint = 1;
	public static int num_putletter = 1;

	public static bool firstlevel = true;
	public static bool secondlevel = false;
	public static bool thirdlevel = false;
	public static bool fourthlevel = false;
	public static bool fifthlevel = false;
	public static bool sixthlevel = false;

	public static bool firstlevel_m = true;
	public static bool secondlevel_m = false;
	public static bool thirdlevel_m = false;
	public static bool fourthlevel_m = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Global.score = Global.eachscore [1] + Global.eachscore [0];
	}

}
