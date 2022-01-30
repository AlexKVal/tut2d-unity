using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityControl : MonoBehaviour
{
    const float maxVel = 20;
		public Rigidbody2D rbToControl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	var prevX = rbToControl.velocity.x;
    	var prevY = rbToControl.velocity.y;

    	if (prevX > maxVel) prevX = maxVel;
    	if (prevX < -maxVel) prevX = -maxVel;

    	if (prevY > maxVel) prevY = maxVel;
    	if (prevY < -maxVel) prevY = -maxVel;

    	rbToControl.velocity = new Vector2(prevX, prevY);
    }
}
