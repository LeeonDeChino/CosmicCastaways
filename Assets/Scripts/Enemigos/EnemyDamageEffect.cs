using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageEffect : MonoBehaviour
{
    private SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    public void VFXDamage()
    {
        if (sprite != null)
        {
            sprite.color = Color.red;
            Invoke("VFXResetColor", 0.1f);
        }
    }

    private void VFXResetColor()
    {
        if (sprite != null)
        {
            sprite.color = Color.white;
        }
    }
}
