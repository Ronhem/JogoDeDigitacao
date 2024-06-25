using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour {

	public WordManager wordManager;
	//O toLower vai fazer com que indentifique a letra ate mesmo se estiver em Capslock
	void Update () {
		foreach (char letter in Input.inputString.ToLower())
		{
			wordManager.TypeLetter(letter);
		}
	}

}
