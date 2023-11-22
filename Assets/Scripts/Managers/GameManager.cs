using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Canvas gameOverCanvas;
    public GameObject pauseCanvas;
    public Canvas hudCanvas;
    public ArduinoInput arduinoInput;
    private int input;
    public Animator castaway, castaway2, castaway3;
    public int castawayCount = 0;
    private bool enPausa = false;

    private void Update()
    {
        input = arduinoInput.value;

        if(input == 4 && !enPausa)
        {
            Pausar();
        }
    }
    private void Pausar()
    {
        enPausa = true;
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);
        hudCanvas.enabled = false;
    }
    public void Reanudar()
    {
        Time.timeScale = 1;
        enPausa = false;
        pauseCanvas.SetActive(false);
        hudCanvas.enabled = true;
    }
    public void LiberarCastaways(int i)
    {
        castawayCount++;      
        switch (i)
        {
            case 1:
                castaway.SetTrigger("save");
                break;
            case 2:
                castaway2.SetTrigger("save");
                break;
            case 3:
                castaway3.SetTrigger("save");
                break;
        }      
    }

   public void GameOver()
   {
        gameOverCanvas.enabled = true;
   }
}
