using UnityEngine;

public class TutorialEnemyComplete : MonoBehaviour
{

    public int enemiesKilled;
    public GameObject congratulationScreen;
    public GameObject rightAndLeftText;
    public GameObject upAndDownText;
    public GameObject zoomText;
    public GameObject shootText;
    public GameObject mainCrosshair;
    public GameObject aimCrosshair;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemiesKilled >= 4)
        {
            congratulationScreen.SetActive(true);
            rightAndLeftText.SetActive(false);
            upAndDownText.SetActive(false);
            zoomText.SetActive(false);
            shootText.SetActive(false);
            mainCrosshair.SetActive(false);
            aimCrosshair.SetActive(false);
            
        }
    }

    public void AddKills()
    {
        enemiesKilled++;
    }

}
