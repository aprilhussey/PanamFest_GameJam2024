using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CooldownTimer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Slider cooldownSlider;

    private float cooldownTime;
    private float cooldownTimer;

    private PlayerController playerController;

    void Awake()
    {
        playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();

        cooldownTime = playerController.cooldownTime;
        cooldownTimer = playerController.cooldownTimer;
    }

    void Start()
    {
        cooldownSlider.maxValue = cooldownTime;
        cooldownSlider.value = cooldownTime;
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer = playerController.cooldownTimer;

        if (cooldownTimer > 0)
        {
            cooldownSlider.value = cooldownTimer;
        }
        else if (cooldownTimer == 0)
        {
            cooldownSlider.value = cooldownTime;
        }

        /*float time =  cooldownTime - Time.deltaTime;

        int seconds = Mathf.FloorToInt(time / 60);
        int milliseconds = Mathf.FloorToInt(time - seconds / 1000);

        string textTime = string.Format("{0:0}:");

        if (seconds > 0)
        {
            cooldownTime = 0;
        }*/
    }
}
