using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Wiloka
{
    public interface IInteractable
    {
        event Action<IInteractable, object> onInteractValueChange;
        event Action<IInteractable> onInteract;

        string name { get; }
        GameObject gameObject { get; }
        Transform transform { get; }

        object interactValue { get; set; }
        object interactedValue { get; }
        string description { get; set; }
        bool isInteractable { get; set; }
        void Interact();
        void Init();
        void OnPlayerArrive();
    }
}

