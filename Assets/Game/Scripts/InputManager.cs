using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using static GameInputAction;
public class InputManager : MonoBehaviour, IPlayerActions
{
    // Variable untuk menyimpan reference object input action 
    private GameInputAction _inputAction;

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            // Memunculkan log interact di console  
            // ketika input interact ditekan 
            Debug.Log("Interact");
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log(context);
    }

    private void Awake()
    {
        // Membuat object GameInputAction dan menyimpan reference nya 
        // ke variable _inputAction 
        _inputAction = new GameInputAction();
        // Mengaktifkan input action 
        _inputAction.Enable();
        // Mengaktifkan action map Player 
        _inputAction.Player.Enable();
        // Memberi tahu bahwa kelas ini akan mendeteksi input dari 
        // action map Player 
        _inputAction.Player.SetCallbacks(this);
    }
}