using Unity.VisualScripting;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    GameObject GameManager;

    [Tooltip("The crit box attatched to the enemy")]
    [SerializeField] GameObject CritHitBox;

    [Tooltip("The body attached to the enemy")]
    [SerializeField] GameObject BodyHitBox;

    private void Awake()
    {
        GameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (CritHitBox == null || BodyHitBox == null)
        {
            if (CritHitBox == null)
            {
                GameManager.GetComponent<GameManager>().PlayerScore += GameManager.GetComponent<GameManager>().CritScore;
            }

            else if (BodyHitBox == null)
            {
                GameManager.GetComponent<GameManager>().PlayerScore += GameManager.GetComponent<GameManager>().NormalScore;
            }

            Destroy(this.gameObject);

        }
    }

}
