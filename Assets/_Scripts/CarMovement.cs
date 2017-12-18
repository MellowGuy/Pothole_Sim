using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CarMovement : MonoBehaviour
{
	[Tooltip("In meters per sec.")]
	[SerializeField] float xSpeed = 10f;

	[Tooltip("Rotation Control Factor: multiplied to xThrow to get roll amount")]
	[SerializeField] float controlRollFactor = -7.5f;

	[Tooltip("xMin/xMax Get determined by camera viewport, padding is buffer from the edges")][Header("Screen Ranges")]
	public float xMin;
	public float xMax;
	public float padding = 1f;

	[Tooltip("xThrow, yThrow gets determined by input controls. Throws between -1 to 1.")]
	public float xThrow, yThrow;

	// Use this for initialization
	void Start()
	{
		float cameraToPlaneDistance = transform.position.z - Camera.main.transform.position.z;
		Vector3 leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, cameraToPlaneDistance));
		Vector3 rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, cameraToPlaneDistance));
		xMin = leftmost.x + padding;
		xMax = rightmost.x - padding;
	}

	// Update is called once per frame
	void Update()
	{
		GetInput();
		ProcessTranslation();
		ProcessRotation();
	}

	private void GetInput()
	{
		xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
		yThrow = CrossPlatformInputManager.GetAxis("Vertical");
	}

	private void ProcessTranslation()
	{
		float xOffset = xThrow * xSpeed * Time.deltaTime;
		float rawXPos = transform.localPosition.x + xOffset;
		float clampedXPox = Mathf.Clamp(rawXPos, xMin, xMax);

		Debug.Log("XoFFset: " + xOffset +" rawXpos: " + rawXPos + " clampedXPos: " + clampedXPox);

		transform.localPosition = new Vector3(clampedXPox, transform.localPosition.y, transform.localPosition.z);
	}

	private void ProcessRotation()
	{
		float roll = xThrow * controlRollFactor;
		transform.localRotation = Quaternion.Euler(0, 0, roll);
	}
}
