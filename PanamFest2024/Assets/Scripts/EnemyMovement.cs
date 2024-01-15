using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] GameObject PointA;
    [SerializeField] GameObject PointB;

    NavMeshAgent Enemy;

    string CurrentTarget;

    [SerializeField] float Timer;
    float TempTimer;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();

        CurrentTarget = "A";
        Enemy.SetDestination(PointA.transform.position);

        TempTimer = Timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer <= 0 && Enemy.remainingDistance < 1)
        {
            if (CurrentTarget == "A")
            {
                CurrentTarget = "B";
                Enemy.SetDestination(PointB.transform.position);
            }

            else if (CurrentTarget == "B")
            {
                CurrentTarget = "A";
                Enemy.SetDestination(PointA.transform.position);
            }

            Timer = TempTimer;
        }
        else if (Timer > 0 && Enemy.remainingDistance < 1)
        {
            Timer -= 1 * Time.deltaTime;
            Debug.Log(Timer);
        }

    }

}
