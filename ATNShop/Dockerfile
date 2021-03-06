#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ATNShop/ATNShop.csproj", "ATNShop/"]
COPY ["ATNShop.DataAccess/ATNShop.DataAccess.csproj", "ATNShop.DataAccess/"]
COPY ["ATNShop.Models/ATNShop.Models.csproj", "ATNShop.Models/"]
COPY ["ATNShop.Utility/ATNShop.Utility.csproj", "ATNShop.Utility/"]
RUN dotnet restore "ATNShop/ATNShop.csproj"
COPY . .
WORKDIR "/src/ATNShop"
RUN dotnet build "ATNShop.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ATNShop.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ATNShop.dll"]