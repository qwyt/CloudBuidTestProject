using UnityEngine;
using System.Collections;


public class SimpleTestRunner : MonoBehaviour {

	// Use this for initialization
	public static void Execute () {

		var testRunner = new GameObject().AddComponent<TestRunner>();

		testRunner.UpdatePlayerSettings();
		testRunner.ThrownAnException();

		Destroy(testRunner.gameObject);
	}

	public void Start(){
		Debug.Log(" --- Starting TestRunner !");
	}

	public void UpdatePlayerSettings(){

		Debug.Log(" ---  TestRunner updating player settings:");

		//increment build number
		UnityEditor.PlayerSettings.iOS.buildNumber = "11";

		UnityEditor.PlayerSettings.bundleIdentifier = "random.noCompany.someApp";
		UnityEditor.PlayerSettings.iOS.applicationDisplayName = "someApp";

		UnityEngine.Assertions.Assert.IsTrue( UnityEditor.PlayerSettings.iOS.buildNumber == "11");
		UnityEngine.Assertions.Assert.IsTrue( UnityEditor.PlayerSettings.iOS.applicationDisplayName == "someApp");
		UnityEngine.Assertions.Assert.IsTrue( UnityEditor.PlayerSettings.bundleIdentifier == "random.noCompany.someApp");


		Debug.Log(
			" ---  \n buildNumber" + UnityEditor.PlayerSettings.iOS.buildNumber +
			" ---  \n bundleIdentifier" + UnityEditor.PlayerSettings.bundleIdentifier +
			" ---  \n applicationDisplayName" + UnityEditor.PlayerSettings.iOS.applicationDisplayName
		);
	
	}

	public void ThrownAnException(){

		Debug.Log(" ---  TestRunner is throwing an Exception!");
		throw new System.Exception("Throwing a standard Exception !");
	}

	void OnDestroy() {
		Debug.Log(" ---  TestRunner destroyed!");
    }

}
