using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public GameObject dialog;
    private GameObject current;

    public void OpenDialog(GameObject detail)
    {
        current = detail;

        dialog.SetActive(true);
        current.SetActive(true);
    }

    public void CloseDialog()
    {
        dialog.SetActive(false);
        current.SetActive(false);
    }
}
