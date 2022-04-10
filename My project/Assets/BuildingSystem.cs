using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSystem : MonoBehaviour
{
    [SerializeField]
    private float speedRotation = 4;

    void Update()
    {
        this.transform.Rotate(new Vector3(0, 1, 0), speedRotation * Time.deltaTime);
    }
}
