using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class ScoreManager : MonoBehaviour
{
    
    public Text ScoreText;
    public int Score = 0;
    public static string Condition;
    public void ChangeScore()
    {
        ScoreText.text = Score.ToString();
    }
    public void AddScore()
    {
        Score += 1;
    }

    
    void Update()
    {
        ChangeScore();
    }
    private void OnEnable()
    {
        CollisionHandler.Collision += AddScore;

    }
    private void OnDisable()
    {
        CollisionHandler.Collision -= AddScore;
    }
}
