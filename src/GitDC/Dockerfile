FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["GitDC/GitDC.csproj", "GitDC/"]
RUN dotnet restore "GitDC/GitDC.csproj"
COPY . .
WORKDIR "/src/GitDC"
RUN dotnet build "GitDC.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "GitDC.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "GitDC.dll"]