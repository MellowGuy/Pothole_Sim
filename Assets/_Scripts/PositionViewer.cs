using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionViewer : MonoBehaviour
{
	void OnDrawGizmos()
	{
		Gizmos.DrawCube(transform.position, transform.localScale);
	}
}
