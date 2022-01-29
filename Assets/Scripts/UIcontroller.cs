using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour
{
    public Scores score;
    
    public Text currentdScoreTxt;
    public Text bestScoreTxt;
    public Text asteroidScoreTxt;
    // Use this for initialization
    void Start()
    {
       
        score.OnScoreChanghed_setUI += SetUI;
        Debug.Log("UI CONTROLLER");
    }

    //private void Score_OnScoreChanghed_setUI(int obj)
    //{
    //    Debug.Log(obj);
    //    currentdScoreTxt.text = obj.ToString();
    //}

    public void SetUI(Score currentScore, Score bestScore, Score asteroidCount)
    {
        currentdScoreTxt.text =(string) currentScore;

        bestScoreTxt.text = (string)bestScore;
        asteroidScoreTxt.text = (string)asteroidCount;
    }
}
    
