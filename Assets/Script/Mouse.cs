using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Texture2D cursor;
    private Vector2 hotspot = new Vector2(10, 4);

    public void OnMouseEnter()
    {
        Cursor.SetCursor(cursor, hotspot, CursorMode.ForceSoftware);
    }

    public void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
    }
}