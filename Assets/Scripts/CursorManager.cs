using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
  [SerializeField] private Texture2D DefaultCursor;
  public Vector2 Cursorhotspot;
  [SerializeField] private Texture2D NewCursor;
  public Vector2 NewCursorhotspot;
 
  public void OnMouseButtonCursorEnter()
  {
    Cursor.SetCursor(DefaultCursor, Cursorhotspot, CursorMode.Auto);
    
  }

  public void OnMouseButtonCursorExit()
  {
    Cursor.SetCursor(NewCursor, NewCursorhotspot, CursorMode.Auto);
  }
}
