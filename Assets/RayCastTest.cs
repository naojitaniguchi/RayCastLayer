using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTest : MonoBehaviour {
    public LayerMask LayerMask;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        // if (Input.GetMouseButton(0))
        {
            // print("左ボタンが押されている");

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //int mask = 1 << 9 ;
            //if (Physics.Raycast(ray, out hit, Mathf.Infinity, mask))
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, LayerMask))
            {
                Debug.Log(hit.transform.gameObject.name);
            }
        }
    }
}
