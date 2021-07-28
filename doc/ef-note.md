1. 安装dotnet ef 

```

dotnet tool install --global dotnet-ef
```

2. 利用脚手架生成数据库


```
// 以下内容在Web层执行
dotnet ef migrations add init -p ../../Infrastructure/RBAC.Infrastructure.Repository/RBAC.Infrastructure.Repository.csproj
```