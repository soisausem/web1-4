using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour {

    float rotSpeed = 0;
    //int MouseSta = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)/*||this.MouseSta==1*/)
        {
            this.rotSpeed = 20;
           // this.MouseSta = 1;
        }

        transform.Rotate(0, 0, this.rotSpeed);

        //if (Input.GetMouseButtonUp(0)||this.MouseSta==0)
        //{
            this.rotSpeed *= 0.97f;
            //this.MouseSta = 0;
        //}
       
	}
}
