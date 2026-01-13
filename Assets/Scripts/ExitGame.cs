using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Клавиша для выхода из игры
    [SerializeField] private KeyCode exitKey = KeyCode.Escape;

    // Update вызывается один раз за кадр
    void Update()
    {
        // Проверяем, нажата ли клавиша выхода
        if (Input.GetKeyDown(exitKey))
        {
            ExitApplication();
        }
    }

    // Метод для выхода из приложения
    private void ExitApplication()
    {
        Debug.Log("Выход из игры...");
        Application.Quit();

        // Для редактора Unity (не работает в сборке)
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
