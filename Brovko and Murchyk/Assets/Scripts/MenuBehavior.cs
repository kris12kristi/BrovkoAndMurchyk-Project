using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuBehavior : MonoBehaviour {
	public void triggerMenuBehavior(int i){
		switch (i) {
		default:
		case(0): 
			SceneManager.LoadScene ("Main");
			break;
		case (1):
			SceneManager.LoadScene ("Welcome");
			break;
		case (2):
			SceneManager.LoadScene ("About");
			break;
		case (3):
			SceneManager.LoadScene ("Level_Map");
			break;
		case (4):
			SceneManager.LoadScene ("Level_1");
			break;
		case (5):
			SceneManager.LoadScene ("Level_2");
			break;
		case (6):
			SceneManager.LoadScene ("Level_3");
			break;
		case (7):
			SceneManager.LoadScene ("Library");
			break;
		case (8):
			SceneManager.LoadScene ("Goodbye");
			break;
		case(9):
			Application.Quit ();
			break;
		}

	}
}
