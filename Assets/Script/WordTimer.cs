using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour {

	public WordManager wordManager;

	public float wordDelay = 3.5f;
	private float nextWordTime = 2.0f;

	private void Update()
	{
		if (Time.time >= nextWordTime)
		{
			wordManager.AddWord();
			nextWordTime = Time.time + wordDelay;
			wordDelay *= .995f;
		}
	}

}
