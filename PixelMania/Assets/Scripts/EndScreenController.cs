using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class EndScreenController : MonoBehaviour
{
    private InputAction leftMouseButtonAction;

    private void OnEnable()
    {
        leftMouseButtonAction = new InputAction("Fire", binding: "<Mouse>/leftButton");
        leftMouseButtonAction.Enable();
        leftMouseButtonAction.performed += _ => ReturnToStartScreen();
    }

    private void OnDisable()
    {
        leftMouseButtonAction.Disable();
        leftMouseButtonAction.performed -= _ => ReturnToStartScreen();
    }

    private void ReturnToStartScreen()
    {
        FindFirstObjectByType<GameSession>().RestartGame();
    }
}
