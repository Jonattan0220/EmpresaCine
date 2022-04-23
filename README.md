EmpresaCine

Prueba Tecnica para el puesto de Desarrollador que utiliza PostgreSQL y ASP. Net Core Web API. 

Se utiliza PostgreSQL 13 y .NET 6 (Soporte extendido)

Utiliza control errores (Si presenta algún error con los paquetes Nuget en .NET, Microsoft recomienda Recompilar el Proyecto y luego si ejecutarlo nuevamente)


Se debe cargar primero la base de datos (se llama cine.sql) al gestor de base de datos PostgreSQL (versión estable). La configuración de la Aplicación tiene la siguiente información pasada a la cadena de conexión: (ConnectionStrings): "Host=localhost;Database=cine;Username=postgres;Password=cine"

(Si decida cambiar la información dada con respecto a la cadena de conexión puede hacerlo en el archivo: appsettings.json una vez clonado el proyecto)

Luego de cargar la base de datos Se puede clonar el proyecto en Visual Studio (versión estable) y posteriormente puede ejecutarlo.

Verá que se desplegará Swagger UI y posteriormente puede trabajar la Aplicación y si desea monitorear los cambios en el gestor de base de datos
