FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 32707
EXPOSE 44350

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["AsyncPlayground/AsyncPlayground.csproj", "AsyncPlayground/"]
RUN dotnet restore "AsyncPlayground/AsyncPlayground.csproj"
COPY . .
WORKDIR "/src/AsyncPlayground"
RUN dotnet build "AsyncPlayground.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AsyncPlayground.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AsyncPlayground.dll"]