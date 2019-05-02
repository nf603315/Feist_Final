using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AgentMotor : MonoBehaviour
{
    public Camera MainCamera;
    public GameObject Player;
    public float Speed = 5;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            float step = Speed * Time.deltaTime;
            transform.position = (ray.direction);
        }

    }
}

