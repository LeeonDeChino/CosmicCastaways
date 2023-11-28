using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Canvas gameOverCanvas;
    public Canvas winCanvas;
    public Canvas hudCanvas;
    public GameObject buttonNavegation;
    
    public Animator castaway, castaway2, castaway3;
    public int castawayCount = 0;

    public bool isGameOver = false;
    public bool isCompleted = false;
    
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
        hudCanvas.enabled = false;
        isGameOver = true;
        buttonNavegation.SetActive(true);
        
        
   }

   public void LevelCompleted()
   {
        winCanvas.enabled = true;
        hudCanvas.enabled = false;
        isCompleted = true;
        buttonNavegation.SetActive(true);
    }
}
