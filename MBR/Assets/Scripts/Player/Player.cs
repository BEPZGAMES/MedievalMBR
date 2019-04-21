using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float hp;
    public float maxHp;
    public float maxInteractionDistance;
    public float money;
    public float movementSpeed;
    public float maxSpeed;
    public float rotationSpeed;
    public float maxRotationSpeed;
    public int handgunAmmo;
    public int shotgunAmmo;
    public int submachineAmmo;
    public int assaultRifleAmmo;
    public int sniperAmmo;
    public Explosive explosives ;
    public enum states {
        homo,
        noHomo
    } ;
    public bool walking;
    public bool shooting;
    public bool reloading;
    public bool changingWeapon;
    public bool driving;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Move (){

    }

    void Rotate(){
        
    }

    void UseWeapon(){
        
    }

    void ChangeWeapon(){
        
    }   
     
    void Interact(){
        
    }

    void TakeDamage (){
        
    }

    void Die (){
        
    }

    IEnumerator ChangingWeapon(){
        yield return 0;
    }

    IEnumerator EnteringCar(){
        yield return 0;
    }

    IEnumerator ExitingCar(){
        yield return 0;
    }

    IEnumerator Consuming(){
        yield return 0;
    }
}
