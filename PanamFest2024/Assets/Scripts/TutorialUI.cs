using System.Collections;
using UnityEngine;

public class TutorialUI : MonoBehaviour
{

    public GameObject rightAndLeftText;
    public GameObject upAndDownText;
    public GameObject zoomText;
    public GameObject shootText;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TextDelay());
    }


    IEnumerator TextDelay()
    {
        yield return new WaitForSeconds(5f);
        rightAndLeftText.SetActive(false);
        upAndDownText.SetActive(true);
        shootText.SetActive(false);
        StartCoroutine(TextDelayTwo());
    }

    IEnumerator TextDelayTwo()
    {
        yield return new WaitForSeconds(5f);
        upAndDownText.SetActive(false);
        zoomText.SetActive(true);
        StartCoroutine(TextDelayThree());
    }

    IEnumerator TextDelayThree()
    {
        yield return new WaitForSeconds(5f);
        shootText.SetActive(true);
        zoomText.SetActive(false);
        StartCoroutine(TextDelay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
