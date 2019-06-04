using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerManager : MonoBehaviour
{
    [SerializeField]
    TextMesh tm;
    [SerializeField]
    TextMesh tm2;
    [SerializeField]
    TextMesh tm3;
    [SerializeField]
    TextMesh tm4;
    [SerializeField]
    TextMesh tm5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        CheckAnalog1D();
        CheckAnalog2D();
        CheckNearTouch();
        CheckTouch();
    }

    void CheckAndOutputText(OVRInput.Button data)
    {
        // if(OVRInput.Get(bt))
        // {
        //     tm.text += bt.ToString() + "\n";
        // }
        if(OVRInput.Get(data))
        {
            tm.text += "<color=#ff0000>";
            tm.text += data.ToString() + "：" + OVRInput.Get(data).ToString() + "\n";
            tm.text += "</color>";
        }
    }
    void CheckAnalog1DAndOutputText(OVRInput.Axis1D data)
    {
        if(OVRInput.Get(data)>0)
        {
            tm2.text += "<color=#ff0000>";
        }
        else
        {
            tm2.text += "<color=#ffffff>";
        }
        tm2.text += data.ToString() + "：" + OVRInput.Get(data).ToString() + "\n";
        tm2.text += "</color>";
    }
    void CheckAnalog2DAndOutputText(OVRInput.Axis2D data)
    {
        if(OVRInput.Get(data)!=Vector2.zero)
        {
            tm3.text += "<color=#ff0000>";
        }
        else
        {
            tm3.text += "<color=#ffffff>";
        }
        tm3.text += data.ToString() + "：" + OVRInput.Get(data).ToString() + "\n";
        tm3.text += "</color>";
    }

    void CheckNearTouchAndOutputText(OVRInput.NearTouch data)
    {
        if(OVRInput.Get(data))
        {
            tm4.text += "<color=#ff0000>";
            tm4.text += data.ToString() + "：" + OVRInput.Get(data).ToString() + "\n";
            tm4.text += "</color>";
        }
    }

    void CheckTouchAndOutputText(OVRInput.Touch data)
    {
        if(OVRInput.Get(data))
        {
            tm5.text += "<color=#ff0000>";
            tm5.text += data.ToString() + "：" + OVRInput.Get(data).ToString() + "\n";
            tm5.text += "</color>";
        }
    }

    void CheckTouch()
    {
        tm5.text = "Touch Check\n";
        CheckTouchAndOutputText(OVRInput.Touch.Any);
        CheckTouchAndOutputText(OVRInput.Touch.Four);
        CheckTouchAndOutputText(OVRInput.Touch.None);
        CheckTouchAndOutputText(OVRInput.Touch.One);
        CheckTouchAndOutputText(OVRInput.Touch.PrimaryIndexTrigger);
        CheckTouchAndOutputText(OVRInput.Touch.PrimaryThumbRest);
        CheckTouchAndOutputText(OVRInput.Touch.PrimaryThumbstick);
        CheckTouchAndOutputText(OVRInput.Touch.PrimaryTouchpad);
        CheckTouchAndOutputText(OVRInput.Touch.SecondaryIndexTrigger);
        CheckTouchAndOutputText(OVRInput.Touch.SecondaryThumbRest);
        CheckTouchAndOutputText(OVRInput.Touch.SecondaryThumbstick);
        CheckTouchAndOutputText(OVRInput.Touch.SecondaryTouchpad);
        CheckTouchAndOutputText(OVRInput.Touch.Three);
        CheckTouchAndOutputText(OVRInput.Touch.Two);
    }


    void CheckNearTouch()
    {
        tm4.text = "NearTouch Check\n";
        CheckNearTouchAndOutputText(OVRInput.NearTouch.Any);
        CheckNearTouchAndOutputText(OVRInput.NearTouch.None);
        CheckNearTouchAndOutputText(OVRInput.NearTouch.PrimaryIndexTrigger);
        CheckNearTouchAndOutputText(OVRInput.NearTouch.PrimaryThumbButtons);
        CheckNearTouchAndOutputText(OVRInput.NearTouch.SecondaryIndexTrigger);
        CheckNearTouchAndOutputText(OVRInput.NearTouch.SecondaryThumbButtons);
    }

    void CheckAnalog2D()
    {
        tm3.text = "Asis2D Check\n";
        CheckAnalog2DAndOutputText(OVRInput.Axis2D.Any);
        CheckAnalog2DAndOutputText(OVRInput.Axis2D.None);
        CheckAnalog2DAndOutputText(OVRInput.Axis2D.PrimaryThumbstick);
        CheckAnalog2DAndOutputText(OVRInput.Axis2D.PrimaryTouchpad);
        CheckAnalog2DAndOutputText(OVRInput.Axis2D.SecondaryThumbstick);
        CheckAnalog2DAndOutputText(OVRInput.Axis2D.SecondaryTouchpad);
    }

    void CheckAnalog1D()
    {
        tm2.text = "Asis1D Check\n";
        CheckAnalog1DAndOutputText(OVRInput.Axis1D.Any);
        CheckAnalog1DAndOutputText(OVRInput.Axis1D.None);
        CheckAnalog1DAndOutputText(OVRInput.Axis1D.PrimaryHandTrigger);
        CheckAnalog1DAndOutputText(OVRInput.Axis1D.PrimaryIndexTrigger);
        CheckAnalog1DAndOutputText(OVRInput.Axis1D.SecondaryHandTrigger);
        CheckAnalog1DAndOutputText(OVRInput.Axis1D.SecondaryIndexTrigger);
    }
    void CheckInput()
    {
        tm.text = "Button Check\n";
        CheckAndOutputText(OVRInput.Button.Any);
        CheckAndOutputText(OVRInput.Button.Back);
        CheckAndOutputText(OVRInput.Button.Down);
        CheckAndOutputText(OVRInput.Button.DpadDown);
        CheckAndOutputText(OVRInput.Button.DpadLeft);
        CheckAndOutputText(OVRInput.Button.DpadRight);
        CheckAndOutputText(OVRInput.Button.DpadUp);
        CheckAndOutputText(OVRInput.Button.Four);
        CheckAndOutputText(OVRInput.Button.Left);
        CheckAndOutputText(OVRInput.Button.None);
        CheckAndOutputText(OVRInput.Button.One);
        CheckAndOutputText(OVRInput.Button.PrimaryHandTrigger);
        CheckAndOutputText(OVRInput.Button.PrimaryIndexTrigger);
        CheckAndOutputText(OVRInput.Button.PrimaryShoulder);
        CheckAndOutputText(OVRInput.Button.PrimaryThumbstick);
        CheckAndOutputText(OVRInput.Button.PrimaryThumbstickDown);
        CheckAndOutputText(OVRInput.Button.PrimaryThumbstickLeft);
        CheckAndOutputText(OVRInput.Button.PrimaryThumbstickRight);
        CheckAndOutputText(OVRInput.Button.PrimaryThumbstickUp);
        CheckAndOutputText(OVRInput.Button.PrimaryTouchpad);
        CheckAndOutputText(OVRInput.Button.Right);
        CheckAndOutputText(OVRInput.Button.SecondaryHandTrigger);
        CheckAndOutputText(OVRInput.Button.SecondaryIndexTrigger);
        CheckAndOutputText(OVRInput.Button.SecondaryShoulder);
        CheckAndOutputText(OVRInput.Button.SecondaryThumbstick);
        CheckAndOutputText(OVRInput.Button.SecondaryThumbstickDown);
        CheckAndOutputText(OVRInput.Button.SecondaryThumbstickLeft);
        CheckAndOutputText(OVRInput.Button.SecondaryThumbstickRight);
        CheckAndOutputText(OVRInput.Button.SecondaryThumbstickUp);
        CheckAndOutputText(OVRInput.Button.SecondaryTouchpad);
        CheckAndOutputText(OVRInput.Button.Start);
        CheckAndOutputText(OVRInput.Button.Three);
        CheckAndOutputText(OVRInput.Button.Two);
        CheckAndOutputText(OVRInput.Button.Up);
    }
}
