# FDV_1.2
 
_**1. Cargar la escena de prueba de los starter assets Third Person**_ 

Importamos el asset [_Starter Assets - ThirdPerson_](https://assetstore.unity.com/packages/essentials/starter-assets-thirdperson-updates-in-new-charactercontroller-pa-196526) desde el Package Manager.

![image](https://github.com/user-attachments/assets/d9ce6383-6aea-462a-b102-71163aa4f125)

Una vez se haya importado el asset, abrimos la escena `Playground`.

![image](https://github.com/user-attachments/assets/59d4bc35-dc96-4d38-ae80-5c1b35c21c42)


**_2. Conservar de la escena el personaje y elimina el entorno._**

![image](https://github.com/user-attachments/assets/8e3c57f9-4565-4e28-a522-43a4d98f2f85)

_**3. Incluye GameObjects del menú**_

Incluimos un plano y tres cubos.

![image](https://github.com/user-attachments/assets/cdbe75da-1f30-41f4-9bbd-bb3d729727d1)

**_4. Incluye GameObjects de la Asset Store_**

Importamos el asset [_Rock and Boulders 2_](https://assetstore.unity.com/packages/3d/props/exterior/rock-and-boulders-2-6947) y añadimos uno de los GameObjects que incluye.

![image](https://github.com/user-attachments/assets/bd96b183-e570-44c4-a4d4-9eaa5f648a85)

![image](https://github.com/user-attachments/assets/6fbdce58-7c51-4444-9aac-f185a80ff022)

_**5. Convierte uno de los GameObjects incluido en el personaje**_

Se añade un cuarto cubo al que se le añaden los componentes `CharacterController`, `PlayerInput`, `ThirdPersonController` y `StarterAssetsInputs`. Además, se le añadirá un hijo que servirá como referencia para que la cámara siga al GameObject.

![image](https://github.com/user-attachments/assets/51deea27-3192-46a3-a1dc-b3614a5b91e9)


_**6. Agregar una fuente de iluminación y configurarla con luz de algún color distinto del blanco**_

Se cambia la variable `Color` del GameObject `Directional Light` al valor `#FF7B98`.

![image](https://github.com/user-attachments/assets/1e43d2b2-ba42-435b-83ce-bc6fb5d69678)


_**7. Generar un script que muestre en consola un mensaje**_

Se crea el siguiente script que mostrará un mensaje cada vez que el personaje colisione con otro objeto:

```c#
using UnityEngine;

public class PlayerLog : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log($"<{gameObject.name}> has hit <{hit.gameObject.name}> collision...");
    }
}

```


![image](https://github.com/user-attachments/assets/a3c0fd83-c2c6-478a-bee3-2cf3ab6a9366)

Resultado:

![FDV_1 2-Gif](https://github.com/user-attachments/assets/33bcd9f2-99f7-48b4-afaa-3ca073c94e91)

