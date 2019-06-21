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

<h3>Install nuget Autofac Packages</h3> 

[Replacing Default Dependency Injection](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.2#default-service-container-replacement)
<dl>
  <dt>Packages</dt>
  <dd>
    <a href="https://www.nuget.org/packages/Autofac/">Autofac</a>
  </dd>
  <dd>
    <a href="https://www.nuget.org/packages/Autofac.Extensions.DependencyInjection/">Autofac.Extensions.DependencyInjection</a>
  </dd>
</dl>

```nuget
Install-Package Autofac -Version 4.9.2
Install-Package Autofac.Extensions.DependencyInjection -Version 4.4.0
```
