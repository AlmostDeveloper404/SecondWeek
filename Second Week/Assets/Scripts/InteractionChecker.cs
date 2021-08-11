using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionChecker : MonoBehaviour
{

    public Transform player;
    [SerializeField]float radius = 2f;

    private void Update()
    {
        float distance = Vector3.Distance(transform.position,player.position);

        if (distance<=2f)
        {
            PickUpCoin();
        }
    }

    void PickUpCoin()
    {
        Destroy(gameObject);
    }
}
