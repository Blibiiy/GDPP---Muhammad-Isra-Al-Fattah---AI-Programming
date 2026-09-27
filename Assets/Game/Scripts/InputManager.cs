using UnityEngine;
using UnityEngine.Events;
public class InputManager : MonoBehaviour
{
    // Membuat event OnSpaceInput 
    public UnityEvent OnSpaceInput;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Trigger event OnSpaceInput 
            OnSpaceInput?.Invoke();
        }
    }
}