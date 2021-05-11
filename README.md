# BASE .NET CORE API APPLICATION

learning dotnet based on tutorial on <https://code-maze.com/net-core-series/>

## Migration

Untuk dapat melakukan Migrasi silahkan unduh folder dari branch **EFCodeFirstApproach**. Kemudian lakukan langkah-langkah berikut untuk mencoba migrasi.

Buka **appsetting.json** pada folder AccountOwnerServer. kemudian silahkan ganti mainConnection sesuai database

>"mainConnection": "server=localhost;userid=root;password=;database=accountowner;"

Selanjutnya, untuk melakukan migrasi, jika anda menggunakan **Visual Studio**, gunakan code di bawah ini pada **Package Management Console** :

``` Code Migrasi Visual Studio
Add-Migration <MigrationName>                   // reate Migration Schema
Update-Database                                 // Sync Migration Schema to DB
Update-Database -Migration 0                    // To Unapply All Migration
Update-Database -Migration <MigrationName>      // To unapply a specific migration(s)
Remove-Migration                                // To remove last migration
Remove-Migration -Force                         // To unapply and remove last migration
```

Jika anda menggunakan **.NET CORE CLI**, gunakan code di bawah ini pada console :

``` Code Migrasi .NET Core CLI
dotnet ef migrations add <MigrationName>        // Create Migration Schema
dotnet ef database update                       // Sync Migration Schema to DB
dotnet ef database update 0                     // To Unapply All Migration
dotnet ef database update <MigrationName>       // To unapply a specific migration(s)
dotnet ef migrations remove                     // To remove last migration
dotnet ef migrations remove --force             // To unapply and remove last migration
```

Untuk menghapus semua migrasi, developer bisa langsung menghapus folder **Migrations**.
