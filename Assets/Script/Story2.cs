using System.Collections;
using UnityEngine;

public class Story2 : MonoBehaviour
{
	[SerializeField] UnityEngine.UI.Text textbox;

	IEnumerator Start()
	{
		textbox.text = "リュウグウノツカイについての展示を見ていたその時…";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

		textbox.text = "周りが急に暗くなった。";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

		textbox.text = "周りが急に暗くなった。僕は慌ててスマホを取り出した。";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

		textbox.text = "(NEXTを押してください)";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;


	}
}

