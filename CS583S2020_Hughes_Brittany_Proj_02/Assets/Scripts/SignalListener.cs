using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class SignalListener : MonoBehaviour
{
    public Signal_Event sig;
    public UnityEvent e;

    public void OnSignalRaised()
    {
        e.Invoke();
    }
    private void Enable()
    {
        sig.RegisterListener(this);
    }
    private void Disable()
    {
        sig.DeRegisterListener(this);
    }
}
