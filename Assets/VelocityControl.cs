using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityControl : MonoBehaviour
{
		public Rigidbody2D rbToControl;
    const int max = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	var prevX = rbToControl.velocity.x;
    	var prevY = rbToControl.velocity.y;

    	if (prevX > max) prevX = max;
    	if (prevX < -max) prevX = -max;

    	if (prevY > max) prevY = max;
    	if (prevY < -max) prevY = -max;

    	rbToControl.velocity = new Vector2(prevX, prevY);

    }
}
