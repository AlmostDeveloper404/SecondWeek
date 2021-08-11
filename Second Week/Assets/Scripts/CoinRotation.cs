using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 90f; 

    private void Update()
    {
        transform.Rotate(0f,0f, rotationSpeed * Time.deltaTime);
    }
}
