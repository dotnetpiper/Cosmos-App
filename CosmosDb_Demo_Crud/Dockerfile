FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY CosmosDb_Demo_Crud/*.csproj ./aspnetapp/
RUN dotnet restore

# copy everything else and build app
COPY CosmosDb_Demo_Crud/. ./aspnetapp/
WORKDIR /app/aspnetapp
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app
COPY --from=build /app/aspnetapp/out ./
ENTRYPOINT ["dotnet", "CosmosDb_Demo_Crud.dll"]
#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

#FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-nanoserver-1803 AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/core/sdk:2.2-nanoserver-1803 AS build
#WORKDIR /src
#COPY ["CosmosDb_Demo_Crud/CosmosDb_Demo_Crud.csproj", "/CosmosDb_Demo_Crud/"]
#COPY ["DataContextLayer/DataContextLayer.csproj", "/DataContextLayer/"]
#COPY ["ModelClass/ModelClass.csproj", "/ModelClass/"]
#RUN dotnet restore "/CosmosDb_Demo_Crud/CosmosDb_Demo_Crud.csproj"
#COPY . .
#WORKDIR "/src/CosmosDb_Demo_Crud"
#RUN dotnet build "CosmosDb_Demo_Crud.csproj" -c Release -o /app
#
#FROM build AS publish
#RUN dotnet publish "CosmosDb_Demo_Crud.csproj" -c Release -o /app
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "CosmosDb_Demo_Crud.dll"]


