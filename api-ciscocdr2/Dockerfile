FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["api-ciscocdr2/api-ciscocdr2.csproj", "api-ciscocdr2/"]
RUN dotnet restore "api-ciscocdr2/api-ciscocdr2.csproj"
COPY . .
WORKDIR "/src/api-ciscocdr2"
RUN dotnet build "api-ciscocdr2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "api-ciscocdr2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "api-ciscocdr2.dll"]