using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class WordDisplay : MonoBehaviour {
	public Text text;
	public float fallSpeed = 1.1f;
	public GameObject explosion;
	public AudioSource type;
	public void SetWord (string word)
	{
		text.text = word;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		Destroy(gameObject);
	}

	public void RemoveLetter ()
	{
		type.Play();
		text.text = text.text.Remove(0, 1);
		text.color = Color.green;
	}

	public void RemoveWord ()
	{
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy(gameObject);
	}

	private void Update()
	{
		transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
	}

}
