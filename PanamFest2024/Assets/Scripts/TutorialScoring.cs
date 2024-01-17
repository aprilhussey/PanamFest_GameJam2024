using UnityEngine;

public class TutorialScoring : MonoBehaviour
{
    [SerializeField] GameManager GameManager;

    [Tooltip("The crit box attatched to the enemy")]
    [SerializeField] GameObject CritHitBox;

    [Tooltip("The body attached to the enemy")]
    [SerializeField] GameObject BodyHitBox;

    TutorialEnemyComplete tutorialEnemyCompleteScript;


    private void Start()
    {
        tutorialEnemyCompleteScript = GameObject.Find("KCO").GetComponent<TutorialEnemyComplete>();
    }
    // Update is called once per frame
    void Update()
    {
        if (CritHitBox == null || BodyHitBox == null)
        {
            if (CritHitBox == null)
            {
                GameManager.PlayerScore += GameManager.CritScore;
            }

            else if (BodyHitBox == null)
            {
                GameManager.PlayerScore += GameManager.NormalScore;
            }


            Destroy(this.gameObject);
            tutorialEnemyCompleteScript.AddKills();
        }
    }
}
