using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;



public class Scores : MonoBehaviour
{
	private bool isPlayerAlive;

	public GameObject player;

	public event Action<Score,Score,Score> OnScoreChanghed_setUI;

	//public Text currentdScoreTxt;
	//public Text bestScoreTxt;
	//public Text asteroidScoreTxt;


	private Score currentScore= new Score();
	private Score bestScore = new Score();
	private Score asteroidCount = new Score();

	private int scoreAcceleration = 1;

	void Start()
	{
		InvokeRepeating("permanentInceaceScore", 0, 1);
		Invoke("isAliveCheck", 0f);
		bestScore=PlayerPrefs.GetInt("bestScoreKey");
       // OnScoreChanghed_setUI += GetComponent<UIcontroller>().SetUI;


    }

	public void IncreaceScore()
	{
	
		if(isPlayerAlive)
		{
			currentScore += 5;
			asteroidCount += 1;
		    //asteroidScoreTxt.text =(string) asteroidCount;
			Debug.Log("Score:" + currentScore);
		}
	}


	private void permanentInceaceScore()
    {

		if (isPlayerAlive)
		{
			
			currentScore += 1 *scoreAcceleration;// МЕНЯТЬ НА +2 когда acceleration =2
			
			OnScoreChanghed_setUI?.Invoke(currentScore,bestScore,asteroidCount);
			//currentdScoreTxt.text = (string)currentScore;
		}
		if (currentScore > bestScore)
		{
			bestScore = currentScore;
			//bestScoreTxt.text = (string)bestScore;
		}
	}

	public void isAliveCheck()
    {
		isPlayerAlive = InputManager.Instance.isPlayerAlive();
	}

	public int GetBestScore()
    {
		return bestScore;
    }

	public void SetCurrentScore(int curSc)
    {
		currentScore = curSc;
    }
	public void SetScoreAcceleration(int scAccceler)
    {
		scoreAcceleration = scAccceler;
    }


}

