using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    // Scores applied when landing a hit
    // Standard body shot
    [Tooltip("The score added for a body shot")]
    public int NormalScore;

    // Headshot/Critical strike
    [Tooltip("The score added for a critical hit")]
    public int CritScore;

    // Player's total score
    [Tooltip("The players total score (shoudln't need touching)")]
    public int PlayerScore;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
