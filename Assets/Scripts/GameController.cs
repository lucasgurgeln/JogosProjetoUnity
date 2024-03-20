using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public float timeRemaining = 30f; 
    public TextMeshProUGUI timeText;
    public GameObject winTextObject; 
    private int moedasColetadas = 0;
    private bool timerAtivo = true;

    void Start() {
        winTextObject.SetActive(false); 
    }

    void Update()
    {
        if (timerAtivo && timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimeText();
        }
        else if (timerAtivo)
        {
            TimeUp();
        }
    }

    public void MoedaColetada() {
        moedasColetadas++;
        if (moedasColetadas >= 12) {
            JogoGanho(); 
        }
    }
    void UpdateTimeText()
    {
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timeText.text = "Tempo: " + seconds.ToString();
    }

    void TimeUp()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void JogoGanho() {
        winTextObject.SetActive(true); 
        timerAtivo = false; 
        SceneManager.LoadScene("MenuPrincipal");
    }
}
