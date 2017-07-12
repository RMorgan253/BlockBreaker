using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log ("Level Load Requested for: " + name);
		Application.LoadLevel(name); 
	}

	public void QuitRequest(){
		Debug.Log ("Player would like to quit");
		Application.Quit();
	}
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void BrickDestroyed(){
		if (Brick.breakableCount <= 0) {
		LoadNextLevel();
		}
	}

}
