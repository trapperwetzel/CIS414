using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Trapper W
// 2/16/2025

public class PlayerPaddle : MonoBehaviour
{
    // Vars
    protected Vector3 movDir = Vector3.zero;
    [SerializeField,Range(1,20)] protected float movSpeed = 1f;
    //[SerializeField, Range(10, 29)] protected float maxSpeed = 25f;



    // Methods
    public void Update()
    {
        MovePaddle();
    }

    public void MoveInput(InputAction.CallbackContext aCon)
    {
        Vector2 av2 = aCon.ReadValue<Vector2>();

        movDir.x = av2.x;
        movDir.z = av2.y;


    }

    // move player paddle

    public void MovePaddle()
    {
        transform.Translate(movDir * movSpeed * Time.deltaTime);    
    }





}
