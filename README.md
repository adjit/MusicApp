# MusicApp
Test Music App Using Entity Framework

Run scaffolding to build model from database
```PowerShell
Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```

<h3>Install nuget NLog Packages</h3> 

[NLog Articles](https://github.com/damienbod/AspNetCoreNlog)
<dl>
  <dt>Packages</dt>
  <dd>
    <a href="https://www.nuget.org/packages/NLog.Web.AspNetCore/">NLog.Web.AspNetCore</a>
  </dd>
  <dd>
    <a href="https://www.nuget.org/packages/NLog/">NLog</a>
  </dd>
</dl>

```nuget
Install-Package NLog.Web.AspNetCore -Version 4.8.3
Install-Package NLog -Version 4.6.5
```


