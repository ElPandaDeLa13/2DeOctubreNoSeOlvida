1. Instalacion de dotnet core ultima version

Visual Studio Code en sí mismo es un editor de ficheros "vitaminado". Esto quiere decir que es como el bloc
de notas de toda la vida, pero con mejoras (muchas mejoras). Por eso, lo primero que tenemos que hacer
para poder usar .NET Core con Visual Studio Code, es instalar .NET Core para nuestra plataforma. Para ello
descargaremos desde su [página de descargas](https://dotnet.microsoft.com/download) los binarios del SDK (Kit de Desarrollo de Software, en
inglés: Software Development Kit) para nuestro sistema operativo.

![alt text](https://www.campusmvp.es/recursos/image.axd?picture=/2019/1T/vscode-netcore/DescargaSDKNetCore.png)
---
2.Instalación y configuración de Visual Studio Code para C#.

Lo primero que debes hacer es instalar Visual Studio Code. Para ello basta con que entremos a su [pagina de
descargas](https://code.visualstudio.com/) y nos descarguemos e instalemos la versión apropiada para nuestro sistema operativo
![alt text](https://www.campusmvp.es/recursos/image.axd?picture=/2019/1T/vscode-netcore/DescargarVSC.png)
---
# Instalando las extensiones necesarias 

Para poder desarrollar todo su potencial, Visual Studio Code utiliza un sistema de extensiones que nos
permiten ampliar su funcionalidad. Estas extensiones se pueden descargar desde el propio entorno o
desde el [Extension Marketplace](https://code.visualstudio.com/docs/editor/extension-gallery) (aunque esto realmente, lo que va a hacer es abrir el IDE y llevarnos a la
extensión).

Para empezar a preparar nuestro entorno, vamos a utilizar la extensión para el lenguaje [C#](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp).

Para instalar esta extensión, desde la web, basta con que pulsemos sobre Install:

![alt text](https://www.campusmvp.es/recursos/image.axd?picture=/2019/1T/vscode-netcore/BotonInstall.png)

Nos va a pedir como requisito tener instalado Visual Studio Code, y como nosotros ya lo tenemos, en la ventana emergente pulsamos sobre el botón Abrir Visual Studio Code:

![alt text](https://www.campusmvp.es/recursos/image.axd?picture=/2019/1T/vscode-netcore/AbrirVSC.png)

Esto nos abre Visual Studio Code, y nos muestra directamente la extensión, aquí basta con pulsar sobre el
botón Install para que se inicie el proceso:

![alt text](https://www.campusmvp.es/recursos/image.axd?picture=/2019/1T/vscode-netcore/BotonInstallVSC.png)

Una vez que termine tenemos que recargar el IDE. Para eso basta con pulsar en el botón de recargar:

![alt text](https://www.campusmvp.es/recursos/image.axd?picture=/2019/1T/vscode-netcore/reload.png)

Con esto, ya tenemos nuestro entorno de trabajo Visual Studio Code para trabajar con el lenguaje C# y con .NET Core.
---
3.Instalación de git. conectado a tu cuenta de GitHub y VSC.

Para empezar, entra a la página de Git, darle click al botón de Downloads for Windows.

![alt text](https://miro.medium.com/max/1280/1*PPHX_iRgCFknW6AOMPGsOw.png)

Una vez descargada, dale click al archivo con el formato Git-version.exe. Al 
inicio preguntará por permisos para ejecutar el instalador, a lo cual debemos responder que sí.

![alt text](https://miro.medium.com/max/493/1*k4o9_OMmScXTL9h15Rb5SQ.png)

Como muchos de los instaladores en Windows, debemos de aceptar las
opciones por defecto y darle Next (siguiente) a todo hasta que nos salga el
botón de instalar.

![alt text](https://miro.medium.com/max/495/1*COpNZF0GQsMNZwPpScuMYA.png)

![alt text](https://miro.medium.com/max/494/1*ccXGscRzG49rBA8NwI6DnQ.png)

![alt text](https://miro.medium.com/max/495/1*SH7rKdvIea0Ob9pMbxuORA.png)

![alt text](https://miro.medium.com/max/495/1*dY-zXW1E8HEYQp5ADIp-IQ.png)

![alt text](https://miro.medium.com/max/496/1*z1DLlbMXdlPk-v2yks11fw.png)

![alt text](https://miro.medium.com/max/496/1*WqRJS0vaIQsZG3Z_MyimGg.png)

![alt text](https://miro.medium.com/max/497/1*IbRFm3WxmKDvD01JB_e_Gw.png)

![alt text](https://miro.medium.com/max/496/1*ZaCJlg0Qjvq2L5bq-lDAKA.png)

Una vez terminada la configuración del instalador de Git, comenzará a
instalar todos los archivos necesarios en la carpeta indicada al inicio.

![alt text](https://miro.medium.com/max/495/1*XYMyRItzk_HQVSoeFXmLkw.png)

Al finalizar la instalación, nos dará la opción de abrir Git Bash para finalizar.

![alt text](https://miro.medium.com/max/496/1*f5qSOOVEtmpqpxvi1Vw1WA.png)

Y ésta será la terminal que usaremos para ingresar comandos Unix y de Git sobre todo:

![alt text](https://miro.medium.com/max/1162/1*bBBa0SA-rGayFEncu-OrUQ.png)
---
# Clonar un repo 

Arrancamos por clonar un repo para ello copiaremos la URL del repo (en este caso tenemos el repo en github pero funcionaría desde bitbucket, gitlab, vsts u otro).

![alt text](https://images.squarespace-cdn.com/content/v1/56cdb491a3360cdd18de5e16/1513097378029-886CMBXT5MSNW110RGW1/ke17ZwdGBToddI8pDm48kNSgfPMYx7IKl8OhSye7_ipZw-zPPgdn4jUwVcJE1ZvWEtT5uBSRWt4vQZAgTJucoTqqXjS3CfNDSuuf31e0tVFuoGgo4HI1QbEoCcoa4dhf3rAv5eZMAZLRod4JDJ5GuB926scO3xePJoa6uVJa9B4/00_clone_repo.png?format=500w)

Para clonar un repo, lo podemos hacer desde la paleta de comandos.

-Para mostrar la paleta de comandos: podemos pulsamos la combinación de teclas CTRL+SHIFT+P o desde el menú view seleccionamos "command palette".

![alt text](https://images.squarespace-cdn.com/content/v1/56cdb491a3360cdd18de5e16/1513097503858-81UIVNA78EG1KQS96JI7/ke17ZwdGBToddI8pDm48kHqd2F6AxQlLxlroQ4qt6dDlfiSMXz2YNBs8ylwAJx2qgRUppHe6ToX8uSOdETM-XldvY_sAIyUlfjhoEMtv77H4H458gcOCs1DDQO9QqmORSPHMG2ZcdNvWi8aCu8e42pyZJLyAa-PwTe3NhAqSuyE/01_command_palette.png?format=750w)

-Desde ahí tecleamos git clone nos pide la ruta del repositorio y ya ponemos clonar (si es necesario nos pide credenciales).

![alt text](https://images.squarespace-cdn.com/content/v1/56cdb491a3360cdd18de5e16/1513097547019-95ZCFWFTASPX65AV2D7E/ke17ZwdGBToddI8pDm48kGkQGg5zSUF3GofhiBY7DCZZw-zPPgdn4jUwVcJE1ZvWQUxwkmyExglNqGp0IvTJZamWLI2zvYWH8K3-s_4yszcp2ryTI0HqTOaaUohrI8PIWK0PTuZwDUiM7jdqNYuTzV2JHljLSAixtYBZKAp4rlc/02_clone_repo.gif?format=1000w)
