using System.Collections;
using UnityEngine;
using UnityEngine.VFX;

public class Scoring : MonoBehaviour
{
    [Tooltip("The crit box attatched to the enemy")]
    [SerializeField] GameObject CritHitBox;

    [Tooltip("The body attached to the enemy")]
    [SerializeField] GameObject BodyHitBox;

    [SerializeField] GameObject bloodEffect;

    // Update is called once per frame
    void Update()
    {
        if (CritHitBox == null || BodyHitBox == null)
        {
            if (CritHitBox == null)
            {
                GameManager.Instance.PlayerScore += GameManager.Instance.CritScore;
            }

            else if (BodyHitBox == null)
            {
                GameManager.Instance.PlayerScore += GameManager.Instance.NormalScore;
            }

            //Destroy(this.gameObject);
            //bloodEffect.Play();
            bloodEffect.SetActive(true);
            StartCoroutine(VFXDelay());

        }
    }

    IEnumerator VFXDelay()
    {
        yield return new WaitForSeconds(1);
        //bloodEffect.SetActive(false);
        Destroy(this.gameObject);
    }
}
