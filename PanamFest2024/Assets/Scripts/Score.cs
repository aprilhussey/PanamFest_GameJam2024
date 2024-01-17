using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    private int score;

    private void Awake()
    {
        score = GameManager.Instance.PlayerScore;
    }
    // Start is called before the first frame update
    void Start()
    {
        score = GameManager.Instance.PlayerScore;
    }

    // Update is called once per frame
    void Update()
    {
        score = GameManager.Instance.PlayerScore;
    }
}
