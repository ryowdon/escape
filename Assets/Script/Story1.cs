using System.Collections;
using UnityEngine;

public class Story1 : MonoBehaviour
{
	[SerializeField] UnityEngine.UI.Text textbox;

	IEnumerator Start()
	{
		textbox.text = "ある日僕は水族館に来ていた。";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

		textbox.text = "ある日僕は水族館に来ていた。久しぶりだからか、すごく楽しかった。";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

		textbox.text = "色々な魚を食い入るように眺めた後、深海魚についての展示をじっくりと見ていた。";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

		textbox.text = "(NEXTを押してください)";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;


	}
}
