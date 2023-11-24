using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Vector3 startPos_personaje;
    public Transform personaje;
    public float velocidad;
    public float rotacion;
    private void Awake()
    {
        startPos_personaje = personaje.position;
    }

    void Update()
    {
        MoveForwardBack();
        ViewRotate();
    }


    void MoveForwardBack()
    {
        Vector3 vec_forward = Vector3.zero;
        vec_forward.z = Input.GetAxis("Straight");
        Vector3 v = new Vector3(0, 0, vec_forward.z) * Time.deltaTime * 1.0f * velocidad;
        personaje.Translate(v, Space.Self);
    }

    void ViewRotate()
    {
        Vector3 vec_rotate = Vector3.zero;                                                     
        vec_rotate.y = Input.GetAxis("Rotacion");                                                 
        Vector3 v = new Vector3(0, vec_rotate.y, 0) * Time.deltaTime * 15.0f * rotacion;   
        personaje.Rotate(v, Space.Self);                                                   
    }

}
