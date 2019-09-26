using UnityEngine;
using System.Collections;


public class ControllerHandel : MonoBehaviour
{
    public float speed = 10.0f;

    public GameObject cube;
    void Start()
    {
    }

    void Update()
    {

        float translationX = Input.GetAxis("Vertical");
        float translationY = Input.GetAxis("Horizontal");



        transform.Translate(speed * translationY * Time.deltaTime, 0f, speed * translationX * Time.deltaTime);


    }
}