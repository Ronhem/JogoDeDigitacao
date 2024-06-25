using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WordManager : MonoBehaviour {

	public List<Word> words;

	public WordSpawner wordSpawner;
	public bool hasActiveWord;
	private Word activeWord;
	public static int score;
	public Highscore hScore;
	public WordColision colision;

    private void Start()
    {
		score = 0;
    }

	public int GetScore()
	{
		return score;
	}

	public void AddWord ()
	{
		//Word(Palavra, Objeto atribuido);
		Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
		Debug.Log(word.word);

		words.Add(word);
	}

	public void TypeLetter (char letter)
	{
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter)
			{
				score += 5;
				activeWord.TypeLetter();
				hScore.CheckHighScore();
            }
            else
            {
				activeWord.WordTyped();
            }
			
		} else
		{
			//ver se tem uma palavra que comeca com letra que o player digitou
			foreach (Word word in words)
			{
				if (word.GetNextLetter() == letter)
				{
					score += 5;
					activeWord = word;
					hasActiveWord = true;
					hScore.CheckHighScore();
					word.TypeLetter();
					break;
				}
                else
                {
					score -= 1;
                }
			}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{
			score += 100;
			hScore.CheckHighScore();
			hasActiveWord = false;
			words.Remove(activeWord);
		}
		if (colision.colisionW == true)
        {
			activeWord.IndexManip();
			colision.colisionW = false;
		}
	}
}