using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Canvas gameOverCanvas;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

   public void GameOver()
   {
        gameOverCanvas.enabled = true;
   }
}
