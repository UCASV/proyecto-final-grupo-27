# Documentación oficial
## **1) Aspectos técnicos:**
### Software utilizado:
---
* #### **Visual studio Community 2019 v16.10.2 (64-bit)**
* #### **.NET 5.0 vSDK 5.0.301 (64-bit)**
* #### **Microsoft SQL Server v15.0.2000.5 Express Edition (64-bit)**
* #### **SQL Server Management Studio(SSMS) v18.9.1 (64-bit)**
<br/>

**Requisitos mínimos .NET 5.0:**
* **Sistemas operativos admitidos:** Windows 10 version 1703 o mayor. Ediciones: Home, Professional, Education, and Enterprise (LTSC y S no son compatibles), Windows 8.1 (con la actualización 2919355): Core, Professional.
* **Procesador:** Procesador de 1 GHz o superior.
* **RAM:** 512 MB.
* **Espacio en disco duro:** Mínimo de 4.5 GB de espacio disponible.

**Requisitos mínimos Visual Studio Community 2019:**
* **Sistemas operativos admitidos:** Windows 10, Windows 8.1 (con la actualización 2919355): Core, Professional y Enterprise, Windows 7 SP1 (con las actualizaciones más recientes de Windows): Home Premium, Professional, Enterprise y Ultimate.
* **Procesador:** Procesador de 1,8 GHz o superior. Se recomiendan cuatro núcleos o superior.
* **RAM:** 2 GB de RAM; 8 GB de RAM recomendado (mínimo de 2,5 GB si se ejecuta en una máquina virtual).
* **Espacio en disco duro:** Espacio en disco duro: mínimo de 800 MB hasta 210 GB de espacio disponible, en función de las características instaladas; las instalaciones típicas requieren entre 20 y 50 GB de espacio libre.
* **Tarjeta Gráfica:** Tarjeta de vídeo que admita una resolución de pantalla mínima de 720p (1280 x 720); Visual Studio funcionará mejor con una resolución de WXGA (1366 x 768) o superior.
* **Requisitos adicionales:** Se requiere .NET framework 4.5.2 o una versión superior para instalar Visual Studio. Visual Studio requiere .NET Framework 4.7.2 para ejecutarse y se instalará durante la configuración (puede ser instalado por separado previamente).

**Requisitos mínimos Microsoft SQL Server Express Edition:**
* **Sistemas operativos admitidos:** Windows 10 TH1 1507 o mayor.
* **Procesador:** Procesador de 1.4 GHz o superior(x64).
* **RAM:** Mínima de 512 MB. Recomendada: 1GB
* **Espacio en disco duro:** Mínimo de 6 GB de espacio disponible.
* **Tarjeta de video:** DirectX 9 o superior
* **Monitor:** Requiere Super-VGA (800x600) o una resolución de monitor mayor.

**Requisitos mínimos Microsoft SQL Server Express Edition:**
* **Sistemas operativos admitidos:** Windows 10 (64-bit) version 1607 (10.0.14393) o mayor, Windows 8.1 (64-bit).
* **Procesador:** 1.8 GHz x86 (Intel, AMD) o un procesador más rápido. 2 núcleos o mayor.
* **RAM:** Mínima de 2 GB. Recomendada: 4GB (2.5 GB como mínimo si es ejecutado en una maquina virtual).
* **Espacio en disco duro:** Mínimo de 2 GB hasta 10 GB de espacio disponible.
### Sistema operativo:
---
### **Windows 10**
**Requisitos minimos:**
* **Procesador:** de 1GHz, o procesador SoC más rápido
* **RAM:** 1 GB para 32 bits o 2 GB para 64 bits
* **Espacio en disco duro:** 16 GB para el sistema operativo de 32 bits o 20 GB para el sistema operativo de 64 bits
* **Tarjeta Gráfica:** Direct 9 o posterior con controlador WDDM 1.0
* **Pantalla:** 800 x 600

### Patrones de diseño implementados:
---
* #### **Patron de diseño: Repository**
* #### **Patron de diseño: Model-View-ViewModel**
<br/>

* ### Patron de diseño: Repository
Este patron tiene como próposito aislar el comportamiento de nuestra base de datos, del de los objetos que utilizamos en el programa. De esta manera dejamos el codigo necesario para la conexion con la base de datos, agregar, guardar , borrar, actualizar, consultar datos, entre otros; dentro de una carpeta aparte que utilizaremos como interfase para luego en una serie de clases nuevas que se utilizaran con un objeto en especifico implementen los metodos de manera que la interacción con la base de datos sea efectiva y personalizada para estos.

La manera que lo utilizamos es que creamos un directorio Repository con las distintas interfaces de repositorio que utilizariamos, ya que teniamos entidades que realizan varias interacciones con la base de datos y otras que solamente realizan una acción y creamos el esquema del metodo a utilizar en la respectiva interfase. Luego creamos un directorio de Services que contienen una serie de clases con la implementacion de cada uno de los metodos necesarios para que la entidad interactúe con la base de datos de manera independiente, en otras palabras cada entidad tiene su forma de implementar los metodos para la interacción de esta con la base de datos.

* ### Patron de diseño: Model-View-ViewModel
El patrón Model-View-ViewModel (MVVM) nos ayuda a separar la lógica de negocio de la interfaz de usuario, facilitando las pruebas, mantenimiento y la escalabilidad de los proyectos. Mantiene únicamente los datos que requieren las vistas y realiza la lógica necesaria para la preparación de dichos datos. Como Modelo tenemos las entidades que ya tenemos previamente en nuestro programa, como ViewModel tendremos un objeto que posee la misma información de la entidad pero se muestra unicamente la información que consideremos relevante mostrar para el usuario, el View es la visualización del objeto que hemos creado con la información relevante.

La manera que lo utilizamos es que creamos una clase que corresponde a la entidad que necesitabamos mostrar al usuario (ViewModel)y en esta agregamos unicamente los campos que necesitabamos, luego creamos una clase estatica que corresponde al mapeado del objeto (el cual quiere decir que alteramos o convertimos un objeto en otro), para nosotros esto significa que convertimos la entidad que teniamos como modelo y la transformamos al objeto viewmodel que muestra la información que necesitabamos, ya al aplicarlo mandabamos reservas hechas por el usuario a mapear al objeto con la información necesaria y eso lo mostrabamos en pantalla.

### Paquetes Nuget implementados:
---
* #### **Microsoft.EntityFrameworkCore.SqlServer v5.0.7**
* #### **Microsoft.EntityFrameworkCore v5.0.7**
* #### **Microsoft.EntityFrameworkCore.Design v5.0.7**
* #### **itext7 v7.1.15**
<br/>

* ### Microsoft.EntityFrameworkCore.SqlServer
Este paquete es utilizado para que permita la interacción de Entity Framework Core con la base de datos Microsoft SQL Server.

* ### Microsoft.EntityFrameworkCore
Este paquete nos permite utilizar las herramientas que posee Entity Framework Core para interactuar desde codigo y vincularse con las bases de datos. Nos permite hacer consultas en LINQ, actualizaciones, trabajar con las entidades de la base de datos como si fueran objetos y utilizar sus propiedades, entre otros usos. En nuestro caso fue utilizado para la interacción con la base de datos en este proyecto, el poder agregar objetos a esta, hacer consulta de datos y mostrar su contenido.

* ### Microsoft.EntityFrameworkCore.Design
Este paquete contiene toda la lógica en tiempo de diseño para Entity Frameqork Core. Es el codigo al que llaman todas las diversas herramientas (como Add-Migration, dotnet ef y ef.exe).

* ### itext7
Este paquete es utilizado para la creacion del archivo PDF, que en nuestro caso contiene todas las reservaciones almacenadas o la reservacion de un ciudadano en especifico utilizamos el paquete NuGet llamado __iText 7__, ya que este nos posibilita la creacion de un archivo por medio de codigo de una manera sencilla, ademas de poder crear este archivo en la carpeta de destino y con el nombre que el usuario de la aplicacion desee.

<br/>

## **2) Instalación del software**

- Antes de empezar:

Antes de poder instalar el programa debemos asegurarnos de tener todo lo necesario para que este nos funcione correctamente.

Lo que necesitamos es: 

> - Instalar el Cliente de Bases de Datos __SQL Express 2019__, debe asegurarse que la cadena de conexion sea igual a la siguiente: __"Server=localhost\\\\SQLEXPRESS;Database=VaccinationProjectDB;Trusted\_Connection=True;"__; ademas debe instalar el Gestor de Bases de Datos __SQL Server Management Studio__.

> - Tener creada la bases de datos y con el banco de datos inicial, esto lo puede hacer ejecutando el query con el nombre __VaccinationProjectDB__, el cual se encuentra en este mismo repositorio en el apartado de _release_.

> - Debe tener instalada la version 5.0.7 de __Entity Framework Core__.

> - Debe tener instalada la version 5.0 de __.NET Core__.

Luego de cumplir estos requisitos, podemos empezar con el proceso de instalacion.

- Paso 1:

Debemos descargar el archivo __Sistema Vacunacion.msi__ el cual es el  instalador de la aplicación. Este archivo se encuentra en el apartado de _releases_ del repositorio.

- Paso 2:

Una vez descargado el archivo lo ejecutamos, nos saldra la  ventana de instalacion, lo que debemos hacer es dar en la opcion siguiente y asi con las demas ventanas.
Si no es solicitado permisos de administrador debemos aceptarlos.

- Paso 3:

Ejecutar el programa dando doble click en el acceso directo del escritorio o en el menu inicio.
