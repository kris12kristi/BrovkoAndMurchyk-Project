using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;

public class GameManeger : MonoBehaviour {
	public Sprite [] cardFace;
	public Sprite cardBack;
	public GameObject [] cards;
	public Text matchText;

	private bool _init = false;
	private int _matches = 10;
		
	// Update is called once per frame
	void Update () {
		if (!_init)
			initializeCards ();

		if (Input.GetMouseButtonUp (0))
			checkCards ();
		}

	void initializeCards (){
		for (int id = 0; id<2; id++){
			for(int i = 1; i<11; i++){

				bool test = false;
				int choice = 0;
				while(!test){

					choice = Random.Range(0, cards.Length);
					test = !(cards [choice].GetComponent<Card> ().initialized);
				}
				cards [choice].GetComponent<Card> ().cardValue = i;
				cards [choice].GetComponent<Card> ().initialized = true;
			}
		}

		foreach (GameObject c in cards) {
			c.GetComponent<Card> ().setupGraphics ();
			if (!_init)
				_init = true;
		}
		
	}

	public Sprite getCardBack(){
		return cardBack;
	}

	public Sprite getCardFace(int i){
		return cardFace [i-1];
	}

	void checkCards(){
		List<int> c = new List<int> ();

		for (int i = 0; i < cards.Length; i++) {
			if (cards [i].GetComponent<Card> ().state == 1)
				c.Add (i);
		}

		if (c.Count == 2)
			cardComparison (c);
	}

	void cardComparison (List<int> c){
		Card.DO_NOT = true;

		int x = 0;

		if (cards [c [0]].GetComponent<Card> ().cardValue == cards [c [1]].GetComponent<Card> ().cardValue) {
			x = 2;
			_matches--;
			matchText.text = "Співпадінь: " + _matches;
			if (_matches == 0)
				SceneManager.LoadScene ("Library");
		}
		for (int i = 0; i < c.Count; i++) {
			cards [c [i]].GetComponent<Card> ().state = x;
			cards [c [i]].GetComponent<Card> ().falseCheck ();
		}
	}



}
