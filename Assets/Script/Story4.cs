using System.Collections;
using UnityEngine;

public class Story4 : MonoBehaviour
{
	[SerializeField] UnityEngine.UI.Text textbox;

	IEnumerator Start()
	{


		textbox.text = "『蛍の光』だ。";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

		textbox.text = "『蛍の光』だ。まさかと思い、ポケットに仕舞い込んでいたパンフレットをスマホで照らす。";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

		textbox.text = "(NEXTを押してください)";
		yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
		yield return null;

	}
}
