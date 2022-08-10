# Net 6 Code First Migration ASP.NET CORE 6 WEB API.

Creamos nuestro proyecto de ASP.NET CORE 6

![createpro](./imgReadme/createpro.jpg)

![framework](./imgReadme/framework.jpg)

Procedemos a instalar en nuestro proyecto 2 paquetes nuggets

> - Microsoft.entityframeworkcore.sqlserver
> - Microsoft.EntityFrameworkCore.Tools

![sqlserverpackage](./imgReadme/sqlserverpackage.jpg)

![toolpackage](./imgReadme/toolpackage.jpg)

Agregamos nuestra primera tabla Genero

![firsttable](./imgReadme/firsttable.jpg)

Configuramos nuestra cadena de conexion

```json
"ConnectionStrings": {
    "DefaultConnection": "Server=DESKTOP-ANEEUI8;Database=PeliculasApi;User=DBUser;Password=DBUser2019"
  }
```
![stringConnection](./imgReadme/stringConnection.jpg)

Creamos nuestro contexto

![Dbcontext](./imgReadme/Dbcontext.jpg)

Configuramos nuestro contexto

![configdbcontext](./imgReadme/configdbcontext.jpg)

Configuramos nuestro Programa para versiones recientes
o startup para versiones inferiores a Net 6

![configProgramaStringConec](./imgReadme/configProgramaStringConec.jpg)


Procedemos a ejecutar comandos en la consola
de Nugget

> - ``Add-Migration Initial``
> * Lo que hace es que nos genera archivos para
crear la base de datos


> - ``Update-Database``
> * Me crea la base de datos si no existe, y si 
ya existe entonces la actualiza.


![generateDB](./imgReadme/generateDB.jpg)

Vemos la base de datos creada

![DbCreated](./imgReadme/DbCreated.jpg)

Mas elementos para crear columnas
```c#

//Configuracion de no permitir eliminacion en cascada
modelBuilder.Entity<FileEntityDB>()
    .HasOne(entity => entity.PkForeign).WithMany()
    .OnDelete(DeleteBehavior.Restrict);

//PrimaryKey
[Key]
[Column("Pk")]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int intPk { get; set; }

//NuevaColumna int Not Null
[Required]
[Column("NameColumn", TypeName = "int")]
public int intNameColumn { get; set; }

//NuevaColumna int Null
[Column("NameColumn", TypeName = "int")]
public int? intNameColumn { get; set; }

//NuevaColumna nvarchar Not Null
[Required]
[Column("NameColumn", TypeName = "nvarchar(100)")]
public String strNameColumn { get; set; }

//ForeingKey Not Null
[Required]
[Column("PkColNameForeing", TypeName = "int")]
public int intPkColNameForeing { get; set; }
[ForeignKey("intPkColNameForeing")]
public FileEntityDBForeing PkColNameForeing { get; set; }

//ForeingKey Null
[Column("PkColNameForeing", TypeName = "int")]
public int? intnPkColNameForeing { get; set; }
[ForeignKey("intnPkColNameForeing")]
public FileEntityDBForeing PkColNameForeing { get; set; }
```

Estas configuraciones tambien las tengo en:
> https://github.com/cesarluilly/ToolAndCommand-VSCode


