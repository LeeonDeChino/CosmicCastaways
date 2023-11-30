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
    public GameObject poste1, poste2, cadena;
    public GameObject ccCam1, ccCam2, ccCam3;
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
                ccCam1.SetActive(true);
                poste1.SetActive(false);
                Invoke("DesactivarCam", 3f);
                break;
            case 2:
                castaway2.SetTrigger("save");
                ccCam2.SetActive(true);
                poste2.SetActive(false);
                Invoke("DesactivarCam", 3f);
                break;
            case 3:
                castaway3.SetTrigger("save");
                ccCam3.SetActive(true);
                cadena.SetActive(false);
                Invoke("DesactivarCam", 3f);
                break;
        }      
    }

    void DesactivarCam()
    {
        if (castawayCount == 1)
        {
            ccCam1.SetActive(false);
        }
        else if (castawayCount == 2)
        {
            ccCam2.SetActive(false);
        }
        else if (castawayCount == 3)
        {
            ccCam3.SetActive(false);
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
