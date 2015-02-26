using UnityEngine;
using System.Collections;

// Stick this on something with a HingeJoint
// For the Hinge Joint on the flipper, you want to make the axis of the
// anchor (the orange thing) perpendicular to the table

public class FlipperController : MonoBehaviour
{
	public float restPosition = 0F;
	public float pressedPosition = 45F;
	public float flipperStrength = 10F;
	public float flipperDamper = 1F;
	public string inputButtonName = "LeftFlipper";
	
	void Awake ()
	{
		hingeJoint.useSpring = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		JointSpring spring = new JointSpring();
		
		spring.spring = flipperStrength;
		spring.damper = flipperDamper;
		
		if (Input.GetButton(inputButtonName))
			spring.targetPosition = pressedPosition;
		else
			spring.targetPosition = restPosition;
		
		hingeJoint.spring = spring;
	}
}
