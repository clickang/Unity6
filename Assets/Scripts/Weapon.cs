using System.Runtime.CompilerServices;
using UnityEngine;

public class Weapon : MonoBehaviour
{    

    void Update()
    {
        RaycastHit hit;

        Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity);

        Debug.Log(hit, Collider.name);
    }
}
