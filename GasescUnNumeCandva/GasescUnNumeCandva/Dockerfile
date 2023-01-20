FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["GasescUnNumeCandva/GasescUnNumeCandva.csproj", "GasescUnNumeCandva/"]
RUN dotnet restore "GasescUnNumeCandva/GasescUnNumeCandva.csproj"
COPY . .
WORKDIR "/src/GasescUnNumeCandva"
RUN dotnet build "GasescUnNumeCandva.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GasescUnNumeCandva.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GasescUnNumeCandva.dll"]
