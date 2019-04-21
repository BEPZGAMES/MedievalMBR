using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vehicle : MonoBehaviour
{
    public float maxHp;  //En caso de que los vehiculos sean destruibles
    public float hp;     //En caso de que los vehiculos sean destruibles
    public float topSpeed;
    public float currentSpeed;
    public float acceleration;
    public float handling;
    public float price;
    public float breaks;

    // Update is called once per frame
    void Update()
    {

    }
}
