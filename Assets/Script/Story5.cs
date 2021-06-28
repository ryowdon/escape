using System.Collections;
using UnityEngine;

public class Story5 : MonoBehaviour
{
	[SerializeField] UnityEngine.UI.Text textbox;

	IEnumerator Start()
	{


		textbox.text = "そのまさかだ。";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

		textbox.text = "そのまさかだ。閉館時間を過ぎている。";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

		textbox.text = "急いで外に出ようとするが、ドアが開かない。";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

		textbox.text = "急いで外に出ようとするが、ドアが開かない。警備の人が鍵を締めてしまったのだろう";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

		textbox.text = "閉じ込められてしまった。";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

		textbox.text = "閉じ込められてしまった。なんとかして外に出なければ！";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

		textbox.text = "(NEXTを押してください)";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

	}
}
