using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Powerups/moveSpeedBuff")]
public class moveSpeedBuff : powerupEffect
{
    public float amount;
    public override void Apply(GameObject target)
    {
        target.GetComponent<BasicMovementReal>().moveSpeed += amount;
        target.GetComponent<SpriteRenderer>().color = Color.magenta;
    }

    
}
