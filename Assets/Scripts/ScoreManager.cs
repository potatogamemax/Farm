using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    public int score = 0;// Start is called once before the first execution of Update after the MonoBehaviour is created
    
        

    // Update is called once per frame
    public void AddScore()
    {
        score++;
        //UpdateHealthHUD();
    }
}
