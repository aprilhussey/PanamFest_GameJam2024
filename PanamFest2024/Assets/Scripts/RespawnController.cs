using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RespawnController : MonoBehaviour
{
    [Tooltip("Assign the version needed (Static or Moving)")]
    [SerializeField] GameObject EnemyPrefab;

    [Tooltip("Assign the respawn point in children")]
    [SerializeField] GameObject RespawnPoint;

    [SerializeField] float Timer;
    float TimeRemaining;

    GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        TimeRemaining = Timer;

        Enemy = Instantiate(EnemyPrefab, RespawnPoint.transform);

        Enemy.transform.position = RespawnPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy == null)
        {
            if (TimeRemaining > 0)
            {
                TimeRemaining -= Time.deltaTime;
            }
            else if (TimeRemaining <= 0)
            {
                Enemy = Instantiate(EnemyPrefab, transform);

                Enemy.transform.position = RespawnPoint.transform.position;

                TimeRemaining = Timer;
            }
        }

    }


}
