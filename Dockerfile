FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build


COPY CosmosDb_Demo_Crud.sln ./
COPY NuGet.config ./ 
COPY ["CosmosDb_Demo_Crud/CosmosDb_Demo_Crud.csproj", "/CosmosDb_Demo_Crud/"]
COPY ["DataContextLayer/DataContextLayer.csproj", "/DataContextLayer/"]
COPY ["ModelClass/ModelClass.csproj", "/ModelClass/"]

RUN dotnet restore
#dotnet add package Microsoft.AspNetCore.StaticFiles -s "C:\Learning\SampleApps\CosmosDb_Demo_Crud\index.json" 
COPY . .
WORKDIR "/CosmosDb_Demo_Crud"	
RUN dotnet build "/CosmosDb_Demo_Crud/CosmosDb_Demo_Crud.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "/CosmosDb_Demo_Crud/CosmosDb_Demo_Crud.csproj" -c Release -o /app

FROM base AS final
WORKDIR /publish
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CosmosDb_Demo_Crud.dll"]