using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class StartScreenController : MonoBehaviour
{
    private InputAction spaceAction;

    private void OnEnable()
    {
        spaceAction = new InputAction("Jump", binding: "<Keyboard>/space");
        spaceAction.Enable();
        spaceAction.performed += _ => StartGame();
    }

    private void OnDisable()
    {
        spaceAction.Disable();
        spaceAction.performed -= _ => StartGame();
    }

    private void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
