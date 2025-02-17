using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    [SerializeField] protected GameObject canvasScene;
    private List<BreakableBrick> bricks;

    public void Awake()
    {
        RoundManager[] g0s = FindObjectsOfType<RoundManager>();

        if (g0s.Length > 1)
        {
            Destroy(gameObject);
        }

        // Initialize bricks list
        bricks = new List<BreakableBrick>(FindObjectsOfType<BreakableBrick>());
    }

    public void Update()
    {
        EndRound();
    }

    // Add this method to remove a brick
    public void RemoveBrick(BreakableBrick brick)
    {
        if (bricks.Contains(brick))
        {
            bricks.Remove(brick);
        }

        EndRound(); // Check if round should end after a brick is removed
    }

    protected void EndRound()
    {
        if (bricks.Count < 1) // Use the list instead of FindObjectsOfType
        {
            canvasScene.SetActive(true);
        }
    }
}
