using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastawayManager : MonoBehaviour
{
    public void DesactivarCastaway()
    {
        Invoke("Desactivar", 5f);
    }

    private void Desactivar()
    {
        gameObject.SetActive(false);    
    }
}
