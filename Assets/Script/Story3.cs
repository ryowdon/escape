using System.Collections;
using UnityEngine;

public class Story3 : MonoBehaviour
{
	[SerializeField] UnityEngine.UI.Text textbox;

	IEnumerator Start()
	{
		textbox.text = "「すみません、誰かいませんか？」";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

		textbox.text = "ライトで当たりを照らしても、他には誰も見当たらない。";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

		textbox.text = "戸惑っていたその時、ふとフェードアウトしていく音楽が聞こえた。";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;


		textbox.text = "(NEXTを押してください)";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

	}
}
