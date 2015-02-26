using UnityEngine;
using System.Collections;

public class leftflip : MonoBehaviour 
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
			{
				spring.targetPosition = pressedPosition;
				audio.PlayDelayed(0.1f);
			}
			else
				spring.targetPosition = restPosition;
			
			hingeJoint.spring = spring;
		}
	}
	
