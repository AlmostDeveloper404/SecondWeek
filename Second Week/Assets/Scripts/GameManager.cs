using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject SoOkText;

    public Text TimeUI;
    public float SecondsRemain;

    
    private void Update()
    {
        SecondsRemain -= Time.deltaTime;
        TimeUI.text = SecondsRemain.ToString("0:00");
        if (SecondsRemain<=0f)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        SoOkText.SetActive(true);
        SoOkText.GetComponent<Text>().text = "Не ок";
        Time.timeScale = 0;
    }
    public void Win()
    {
        SoOkText.SetActive(true);
        SoOkText.GetComponent<Animation>().Play();
        Time.timeScale = 0;
    }
}
