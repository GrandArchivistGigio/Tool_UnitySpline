using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Sc_Spline))]
public class SplineOption
{
	
	private const int MenuPriority = 11;


	[MenuItem("GameObject/Spline", priority = MenuPriority)]
	private static void CreateButton()
	{
		GameObject splineObj = ObjectFactory.CreateGameObject("Spline", typeof(Sc_Spline));
	}


}
