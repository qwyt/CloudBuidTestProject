using UnityEngine;
using UnityEditor;
using System.Collections;



public static class CloudTest  {

	public static void StartMain () {

		SimpleTestRunner.Execute();
	}


	public static void PreExportUpdateAppData(){

		Debug.LogWarning( " Pre-Export : UpdateAppData \n buildNumber = 13 \n applicationDisplayName = someApp_RandomName_111");

		UnityEditor.PlayerSettings.iOS.buildNumber = "13";
		UnityEditor.PlayerSettings.iOS.applicationDisplayName = "someApp_RandomName_111";
	}

	public static void PostExportDebugLog(){

		Debug.LogWarning( " Post-Export : function called");

	}

}


