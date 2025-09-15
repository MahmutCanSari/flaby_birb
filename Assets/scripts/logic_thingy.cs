using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class logic_thingy : MonoBehaviour
{
    public int score = 0;
    public int hi_score = 0;
    public Text scoreText;
    public Text hi_scoreText;
    public GameObject game_over;

    [ContextMenu("score up")]

    void Start()
    {
        if (PlayerPrefs.HasKey("hi_score"))
        {
            hi_score = PlayerPrefs.GetInt("hi_score");
        }
        else
        {
            PlayerPrefs.SetInt("hi_score",hi_score);
        }
        hi_scoreText.text = hi_score.ToString();
    }

    public void addscore(int addscore)
    {
        score += addscore;

        scoreText.text = score.ToString();

    }

    public void replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void gameOver()
    {
        game_over.SetActive(true);
        if (score >= hi_score)
        {
            hi_score = score;
            PlayerPrefs.SetInt("hi_score", hi_score);
        }
        hi_scoreText.text = hi_score.ToString();
        Time.timeScale = 0;
    }
}
