using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchVideos : MonoBehaviour {
	// Initializing the videos for each station
	public GameObject station1;
	public GameObject station2;
	public GameObject station3;
	public GameObject station4;
	public GameObject station5;
	//array of stations
	private GameObject[] stations;

	// Use this for initialization
	public void Awake () {
		stations = new GameObject[5];
		stations[0] = station1;
		stations[1] = station2;
		stations[2] = station3;
		stations[3] = station4;
		stations[4] = station3;

	}

	/// <summary>
	/// Shows the main menu.
	/// </summary>
	public void ShowMainMenu() {
		ShowContent(-1);
	}

	public void Station1() {
		ShowContent(0);
	}

	public void Station2() {
		ShowContent(1);
	}

	public void Station3() {
		ShowContent(2);
	}
	public void Station4() {
		ShowContent(3);
	}

	public void Station5() {
		ShowContent(4);
	}


	/// <summary>
	/// Update is called once per frame.
	/// </summary>
	/// <param name="index">Index.</param>
	private void ShowContent (int index) {

		for (int i = 0; i < stations.Length; i++) {
			if (stations[i] != null) {

				if (i != index) {
					if (stations[i].activeSelf) {
						stations[i].GetComponentInChildren<GvrVideoPlayerTexture>().CleanupVideo();
					}
				} else {
					stations[i].GetComponentInChildren<GvrVideoPlayerTexture>().ReInitializeVideo();
				}
				stations[i].SetActive(i == index);
			}
		}
		GetComponent<Canvas>().enabled = index == -1;
	}
		
}
