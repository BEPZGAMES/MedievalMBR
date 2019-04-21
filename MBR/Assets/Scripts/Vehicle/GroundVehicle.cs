using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundVehicle : Vehicle
{
    public InputManager im;
    
    public List<WheelCollider> throttleWheels;
    public List<WheelCollider> steeringWheels;
    public float strengthCoefficient = 20000f;
    public float maxTurn = 20;
    public ParticleSystem exhaustFx;
    public ParticleSystem[] miniexhaustFx;

    public GameObject[] lights;

    private bool breaking = false;
    private float xRot = 0;

    void Start()
    {
        im = GetComponent<InputManager>();
        breaks = 4f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (WheelCollider wheel in throttleWheels)
        {
            wheel.motorTorque = strengthCoefficient * Time.deltaTime * im.throttle -this.breaks;
            wheel.gameObject.transform.Rotate(xRot, 0, 0);
            
        }

        foreach (WheelCollider wheel in steeringWheels)
        {
            wheel.steerAngle = maxTurn * im.steer;
        }

        if (im.throttle > 0)
        {
            xRot += 1f;
            exhaustFx.Play();
            miniexhaustFx[0].Play();
            miniexhaustFx[1].Play();
            breaking = false;
        }

        if (im.throttle < 0)
        {
            xRot -= 0.5f;
            lights[0].SetActive(true);
            lights[1].SetActive(true);
            breaking = true;
        }

        if(im.throttle == 0)
        {
            xRot = 0f;
            breaking = false;
        }

        if (!breaking)
        {
            lights[0].SetActive(false);
            lights[1].SetActive(false);
        }

    }
}
