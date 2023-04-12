using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    GameObject Sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontalValue = Input.GetAxis("Horizontal");
        float verticalValue = Input.GetAxis("Vertical");

        if(horizontalValue != 0)
        {
            print("Horizontal movement selected: " + horizontalValue);
        }

        if(verticalValue != 0)
        {
            print("Vertical movement selected: " + verticalValue);
        }

        if(Input.GetKey(KeyCode.M))
        {
            print("The M key is pressed down");
        }

        if(Input.GetKey(KeyCode.O))
        {
            print("The O key is pressed down");
        }

        float mousexValue = Input.GetAxis("Mouse X");
        float mouseyValue = Input.GetAxis("Mouse Y");

        if(mousexValue != 0)
        {
            print("Mouse X movement is " + mousexValue);
        }

        if(mouseyValue != 0)
        {
            print("Mouse Y movement is " + mouseyValue);
        }

        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");
        if (hVal != 0)
        {
            print("Horicontal movement selected: " + hVal);
            print("Vertical movement selected: " + vVal);

        }

        bool isKeyDown = Input.GetKey(KeyCode.K);

        if (x = -1.5, z = -1.5)
        {
            void OnTriggerEnter (Collider other)
            {
                print(other.gameObject.name + " has entered the cube");
            }

            void OnTriggerStay (Collider other)
            {
                print(other.gameObject.name + " is still in the cube")
            }

            void OnTriggerExit (Collider other)
            {
                print(other.gameObject.name + " has left the cube");
            }

            if(X = -1.5, Z = -5)
        {
            void OnTriggerEnter (Collider other)
            {
                print(other.gameObject.name + " has entered the cube");
            }

            void OnTriggerStay (Collider other)
            {
                print(other.gameObject.name + " is still in the cube")
            }

            void OnTriggerExit (Collider other)
            {
                print(other.gameObject.name + " has left the cube");
            }

        }
        
    }
}
