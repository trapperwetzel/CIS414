using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Trapper W
// 2/16/2025


public class BreakableBrick : MonoBehaviour
{


    [SerializeField,Range(1,20)] protected int hitsToBreak;
    protected int curHitsToBreak = 0;

    public void Awake()
    {
        curHitsToBreak = hitsToBreak;
    }

    public void Break(int aDamage)
    {
        curHitsToBreak -= aDamage;

        BreakBrick();
        
    }

    protected void BreakBrick()
    {
        if (curHitsToBreak <= 0)
        {
            RoundManager roundManager = FindObjectOfType<RoundManager>();
            if (roundManager != null)
            {
                roundManager.RemoveBrick(this);
            }

            Destroy(gameObject);
        }
    }





}
